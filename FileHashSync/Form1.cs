using FileHashSync.Services;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace FileHashSync
{
    public partial class Form1 : Form
    {
        private string selectedPath = "";
        private bool IsCompared = false;

        public Form1()
        {
            InitializeComponent();

            listViewFiles.View = View.Details;
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;

            listViewFiles.Columns.Add("FileName", 300);
            listViewFiles.Columns.Add("CurrentHash", 200);
            listViewFiles.Columns.Add("CsvHash", 200);
        }

        private void loadPathBtn_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedPath = fbd.SelectedPath;
                DirectoryPathTxt.Text = selectedPath;

                new Thread(LoadFiles) { IsBackground = true }.Start();
            }
        }

        void LoadFiles()
        {
            listViewFiles.Invoke(() =>
            {
                listViewFiles.Items.Clear();
                prgBar.Value = 0;
            });

            FileScanner.Scan(selectedPath,
                (processed, total, fullPath, relativePath, hash) =>
                {
                    var item = new ListViewItem(relativePath);
                    item.SubItems.Add(hash);
                    item.SubItems.Add("");
                    item.Tag = fullPath;

                    listViewFiles.Invoke(() =>
                    {
                        listViewFiles.Items.Add(item);
                        prgBar.Value = processed * 100 / total;
                    });
                });

            IsCompared = false;
        }


        private void exportCsvBtn_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "hashes.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                CsvService.Export(sfd.FileName, listViewFiles.Items);
        }

        private void LoadCSVBtn_Click(object sender, EventArgs e)
        {
            if (IsCompared) return;

            var csv = CsvService.LoadFromDialog();
            if (csv == null) return;

            foreach (ListViewItem item in listViewFiles.Items)
            {
                if (csv.TryGetValue(item.Text, out string hash))
                {
                    item.SubItems[2].Text = hash;
                    item.BackColor = item.SubItems[1].Text == hash
                        ? Color.LightGreen
                        : Color.LightCoral;

                    csv.Remove(item.Text);
                }
                else
                {
                    item.SubItems[2].Text = "Not in CSV";
                    item.BackColor = Color.LightYellow;
                }
            }

            foreach (var missing in csv)
            {
                var item = new ListViewItem(missing.Key);
                item.SubItems.Add("Not in Your Files");
                item.SubItems.Add(missing.Value);
                item.BackColor = Color.Red;
                listViewFiles.Items.Add(item);
            }

            IsCompared = true;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (!IsCompared) return;

            using FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileExporter.ExportModified(listViewFiles.Items, fbd.SelectedPath);
                MessageBox.Show("Modified files exported successfully");
            }
        }
    }
}
