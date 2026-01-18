namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var cacheFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testCacheFile.txt");

           var dir1 = Directory.CreateDirectory("TestFolder1");

           var subdir1 = dir1.CreateSubdirectory("SubFolder1");
            var subdir2 = dir1.CreateSubdirectory("SubFolder2");

            subdir1.CreateSubdirectory("SubsubFolder3");

            File.WriteAllText(Path.Combine(subdir1.FullName, "File.txt"), "Test content");

            Console.ReadKey();
        }
    }
}
