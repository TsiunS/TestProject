namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var cacheFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testCacheFile222.txt");

           var dir1 = Directory.CreateDirectory("TestFolder222");

           var subdir1 = dir1.CreateSubdirectory("SubFolder44");
            // var subdir2 = dir1.CreateSubdirectory("SubFolder3");

            // subdir1.CreateSubdirectory("SubsubFolder4");

            File.WriteAllText(Path.Combine(dir1.FullName, "AAAAAAA.txt"), "Test content44444444444");

            File.WriteAllText(Path.Combine(subdir1.FullName, "Subfile22222.txt"), "Test content222");

            Console.ReadKey();
        }
    }
}
