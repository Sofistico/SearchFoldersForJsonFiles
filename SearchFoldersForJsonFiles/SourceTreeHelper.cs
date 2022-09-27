using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFoldersForJsonFiles
{
    public static class SourceTreeHelper
    {
        public static IReadOnlyList<T> GetSourceTree<T>(string wildCard, SearchOption option)
        {
            string[] files = FileUtils.GetFiles(wildCard, option);

            List<List<T>> listTList = new();

            for (int i = 0; i < files.Length; i++)
            {
                listTList.Add(JsonUtils.JsonDeseralize<List<T>>(files[i]));
            }
            List<T> allTList = new();

            foreach (List<T> tList in listTList)
            {
                if (tList is null)
                    continue;
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