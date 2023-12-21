using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("C:filename.txt");
        string directoryPath = Console.ReadLine();

        try
        {
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            // Получение всех файлов в каталоге
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                // Проверка расширения файла на .txt
                if (file.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // Создание нового имени файла
                    string newFileName = Path.GetFileNameWithoutExtension(file.Name) + "NEW" + file.Extension;

                    // Изменение имени файла
                    file.MoveTo(Path.Combine(file.Directory.FullName, newFileName));

                    Console.WriteLine($"Файл '{file.Name}' переименован в '{newFileName}'");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при переименовании файлов: {e.Message}");
        }
    }
}