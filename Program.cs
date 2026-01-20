namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var cacheFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testCacheFile222.txt");

           var dir1 = Directory.CreateDirectory("TestFolder333");

           var subdir1 = dir1.CreateSubdirectory("SubFolder5555");
            // var subdir2 = dir1.CreateSubdirectory("SubFolder3");

            // subdir1.CreateSubdirectory("SubsubFolder4");

            File.WriteAllText(Path.Combine(dir1.FullName, "AAAASSSSAAA.txt"), "Test content44444444444");

            File.WriteAllText(Path.Combine(subdir1.FullName, "Subfile2228822.txt"), "Test content222");

            Console.ReadKey();
        }
    }
}
