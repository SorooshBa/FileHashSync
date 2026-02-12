using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileHashSync.Services
{
    public static class CsvService
    {
        public static void Export(string filePath, ListView.ListViewItemCollection items)
        {
            var sb = new StringBuilder();
            sb.AppendLine("FileName,CurrentHash");

            foreach (ListViewItem item in items)
            {
                sb.AppendLine($"{Escape(item.Text)},{Escape(item.SubItems[1].Text)}");
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        public static Dictionary<string, string> LoadFromDialog()
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return null;

            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var lines = File.ReadAllLines(ofd.FileName);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var parts = ParseLine(lines[i]);
                if (parts.Length >= 2 && !dict.ContainsKey(parts[0]))
                {
                    dict.Add(parts[0], parts[1]);
                }
            }

            return dict;
        }

        private static string Escape(string value)
        {
            if (value.Contains('"') || value.Contains(',') || value.Contains('\n'))
            {
                return $"\"{value.Replace("\"", "\"\"")}\"";
            }
            return value;
        }

        private static string[] ParseLine(string line)
        {
            var list = new List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            foreach (char c in line)
            {
                if (c == '"')
                    inQuotes = !inQuotes;
                else if (c == ',' && !inQuotes)
                {
                    list.Add(sb.ToString());
                    sb.Clear();
                }
                else
                    sb.Append(c);
            }

            list.Add(sb.ToString());
            return list.ToArray();
        }
    }
}
