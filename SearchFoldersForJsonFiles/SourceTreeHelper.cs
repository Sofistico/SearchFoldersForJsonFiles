using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFoldersForJsonFiles
{
    public static class SourceTreeHelper
    {
        public static IReadOnlyList<T> GetSourceTree<T>(string wildCard)
        {
            string[] files = FileUtils.GetFiles(wildCard);

            List<List<T>> listTList = new();

            for (int i = 0; i < files.Length; i++)
            {
                listTList.Add(JsonUtils.JsonDeseralize<List<T>>(files[i]));
            }
            List<T> allTList = new();

            foreach (List<T> tList in listTList)
            {
                foreach (T t in tList)
                {
                    allTList.Add(t);
                }
            }

            IReadOnlyList<T> readOnlyList = allTList.AsReadOnly();

            return readOnlyList;
        }

        public static IReadOnlyList<T> GetSourceTreeWithSubfolders<T>(string wildCard, string extensionToSearch)
        {
            string[] files = FileUtils.GetFiles(wildCard);

            List<List<T>> listTList = new();

            for (int i = 0; i < files.Length; i++)
            {
                listTList.Add(JsonUtils.JsonDeseralize<List<T>>(files[i]));
            }
            List<T> allTList = new();

            foreach (List<T> tList in listTList)
            {
                foreach (T t in tList)
                {
                    allTList.Add(t);
                }
            }

            IReadOnlyList<T> readOnlyList = allTList.AsReadOnly();

            return readOnlyList;
        }
    }
}