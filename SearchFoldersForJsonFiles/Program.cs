namespace SearchFoldersForJsonFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfResearches = SourceTreeHelper.GetSourceTree<object>(@".\Research\research_*.json");
            var listOfJsons = SourceTreeHelper.GetSourceTree<object>(@".\Research\*.json");
            var listOfEverything = SourceTreeHelper.GetSourceTreeWithSubfolders<object>(@".\Research\*", ".json");

            Console.WriteLine($"List of res : {listOfResearches}");
            Console.WriteLine($"List of jsons : {listOfJsons}");
            Console.WriteLine($"List of every : {listOfEverything}");
        }
    }
}