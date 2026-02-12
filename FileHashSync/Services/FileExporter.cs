using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace FileHashSync.Services
{
    public static class FileExporter
    {
        public static void ExportModified(ListView.ListViewItemCollection items, string destination)
        {
            foreach (ListViewItem item in items)
            {
                if (item.BackColor == Color.LightCoral ||
                    item.BackColor == Color.LightYellow)
                {
                    string sourcePath = item.Tag as string;
                    if (string.IsNullOrEmpty(sourcePath))
                        continue;

                    string destPath = Path.Combine(destination, item.Text);
                    Directory.CreateDirectory(Path.GetDirectoryName(destPath));
                    File.Copy(sourcePath, destPath, true);
                }
            }
        }
    }
}
