using System;
using System.IO;

namespace SearchFoldersForJsonFiles
{
    internal class FileUtils
    {
        private static readonly string _appDomain = AppDomain.CurrentDomain.BaseDirectory;

        public static string[] GetFiles(string wildCard, SearchOption searchOption)
        {
            string originalWildCard = wildCard;

            string pattern = Path.GetFileName(originalWildCard);
            string realDir = originalWildCard[..^pattern.Length];

            // Get absolutepath
            string absPath = Path.GetFullPath(Path.Combine(_appDomain, realDir));

            string[] files = Directory.GetFiles(absPath, pattern, searchOption);
            return files;
        }
    }
}