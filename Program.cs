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

      


        public static List<Tuple<string, DateTime>> GetFilesWithCreateDates(string baseDirectory)
        {
            List<Tuple<string, DateTime>> result = new List<Tuple<string, DateTime>>();

            // Получаем массив путей ко всем файлам в директории и её подпапках
            string[] allFiles = Directory.GetFiles(baseDirectory, "*.*", SearchOption.AllDirectories);

            for (int i = 0; i < allFiles.Length; i++)
            {
                string fullFilePath = allFiles[i];
                string relativePath = fullFilePath.Substring(baseDirectory.Length);

                // Удаляем возможный ведущий символ "/"
                if (relativePath.StartsWith("\\\\") || relativePath.StartsWith("/"))
                {
                    relativePath = relativePath.Substring(1);
                }

                try
                {
                    // Запрашиваем дату создания файла
                    DateTime creationTimeUtc = File.GetCreationTimeUtc(fullFilePath);

                    // Добавляем кортеж в результирующий список
                    Tuple<string, DateTime> tupleItem = new Tuple<string, DateTime>(relativePath, creationTimeUtc);
                    result.Add(tupleItem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при обработке файла " + fullFilePath + ": " + ex.Message);
                }
            }

            return result;
        }
    

    }
}
