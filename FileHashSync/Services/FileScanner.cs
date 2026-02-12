using System.Collections.Generic;
using System.IO;

namespace FileHashSync.Services
{
    public class FileScanner
    {
        public static List<(string FullPath, string RelativePath, string Hash)> Scan(string basePath)
        {
            var result = new List<(string, string, string)>();

            var files = Directory.EnumerateFiles(basePath, "*.*", SearchOption.AllDirectories);

            foreach (var fullPath in files)
            {
                string relativePath = Path.GetRelativePath(basePath, fullPath);
                string hash = HashHelper.CalculateMD5(fullPath);

                result.Add((fullPath, relativePath, hash));
            }

            return result;
        }
    }
}
