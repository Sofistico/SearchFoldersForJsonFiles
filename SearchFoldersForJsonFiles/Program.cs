namespace SearchFoldersForJsonFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // normal use case:
            var listOfResearches = SourceTreeHelper.GetSourceTree<object>(@".\Research\research_*.json", SearchOption.AllDirectories);
            // find everything that has json in the folder:
            var listOfJsons = SourceTreeHelper.GetSourceTree<object>(@".\Research\*.json", SearchOption.TopDirectoryOnly);
            // find everything that ends with json in the 
            var listOfEverything = SourceTreeHelper.GetSourceTree<object>(@".\Research\*", SearchOption.AllDirectories);

            // use case where you search for a specific prefix or word inside the folder and subfolders
            var bodoies = SourceTreeHelper.GetSourceTree<object>(@".\Bodies\body_*", SearchOption.AllDirectories);

            var listOfLimbs = SourceTreeHelper.GetSourceTree<object>(@".\Bodies\limb_*", SearchOption.TopDirectoryOnly);

            // same as above, search everything inside the folder for the specified json
            var listOfOrgans = SourceTreeHelper.GetSourceTree<object>(@".\Bodies\organs_*.json", SearchOption.TopDirectoryOnly);

            Console.WriteLine($"List of res : {listOfResearches}");
            Console.WriteLine($"List of jsons : {listOfJsons}");
            Console.WriteLine($"List of every : {listOfEverything}");

            Console.WriteLine($"List of limbs : {listOfLimbs}");
            Console.WriteLine($"List of organs : {listOfOrgans}");
            Console.WriteLine($"List of bodies : {bodoies}");
        }
    }
}