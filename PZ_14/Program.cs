
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\pz_14.txt"; // указать путь к вашему файлу

        decimal totalSum = 0;

        try
        {
            // Чтение файла построчно
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Разделение строки на индекс и сумму
                string[] parts = line.Split(' ');

                if (parts.Length == 2)
                {
                    // Попытка преобразования суммы в десятичное число
                    if (decimal.TryParse(parts[1], out decimal sum))
                    {
                        totalSum += sum;
                    }
                }
            }

            Console.WriteLine($"Общая сумма: {totalSum}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при чтении файла: {e.Message}");
        }
    }
}