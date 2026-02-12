using System;
using System.Collections.Generic;
using System.IO;

namespace FileHashSync.Services
{
    public class FileScanner
    {
        public static void Scan(
            string basePath,
            Action<int, int, string, string, string> onFileProcessed
        )
        {
            var files = Directory
                .EnumerateFiles(basePath, "*.*", SearchOption.AllDirectories)
                .ToList();

            int total = files.Count;

            for (int i = 0; i < total; i++)
            {
                string fullPath = files[i];
                string relativePath = Path.GetRelativePath(basePath, fullPath);
                string hash = HashHelper.CalculateMD5(fullPath);

                onFileProcessed?.Invoke(
                    i + 1,            // processed
                    total,            // total
                    fullPath,
                    relativePath,
                    hash
                );
            }
        }
    }
}
