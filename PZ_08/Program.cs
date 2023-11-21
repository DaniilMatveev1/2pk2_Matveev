namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][];
            Random random = new Random();
            for (int i = 0; i < 5; i++) // Генерация ступенчатого массива
            {
                int length = random.Next(4, 20); // Генерация случайной длины второго измерения
                jaggedArray[i] = new int[length];
                for (int j = 0; j < length; j++) // Заполнение массива случайными значениями
                {
                    jaggedArray[i][j] = random.Next(100); // Генерация случайного числа от 0 до 99
                }
            }
            Console.WriteLine("Сгенерированный массив:");    // Вывод сгенерированного массива
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)

                    Console.Write(jaggedArray[i][j] + " ");
                Console.WriteLine();
            }
            int[] lastElements = new int[5]; // Создание нового одномерного массива и запись последних элементов каждой строки
            for (int i = 0; i < 5; i++)
            {
                lastElements[i] = jaggedArray[i][jaggedArray[i].Length - 1];
            }
            Console.WriteLine("Массив последних элементов каждой строки:");  // Вывод массива последних элементов
            for (int i = 0; i < lastElements.Length; i++)
            {
                Console.WriteLine(lastElements[i]);
            }
            int[] maxElements = new int[5]; // Нахождение максимального элемента в каждой строке и запись в новый массив
            for (int i = 0; i < 5; i++)
            {
                int maxElement = int.MinValue;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > maxElement)
                    {
                        maxElement = jaggedArray[i][j];
                    }
                }
                maxElements[i] = maxElement;
            }
            Console.WriteLine("Массив максимальных элементов в каждой строке:");  // Вывод массива максимальных элементов
            for (int i = 0; i < maxElements.Length; i++)
            {
                Console.WriteLine(maxElements[i]);
            }
            for (int i = 0; i < 5; i++) // Поменять местами первый элемент и максимальный элемент в каждой строке
            {
                int firstElement = jaggedArray[i][0];
                jaggedArray[i][0] = maxElements[i];
                maxElements[i] = firstElement;
            }
            Console.WriteLine("Обновленный массив после замены первого и максимального элементов:");  // Вывод обновленного массива
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)  // Реверс каждой строки ступенчатого массива
            {
                Array.Reverse(jaggedArray[i]);
            }
            Console.WriteLine("Массив после реверса строк:");   // Вывод массива после реверса строк
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            double[] averageValues = new double[5];  // Подсчет среднего значения в каждой строке
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    sum += jaggedArray[i][j];
                }
                averageValues[i] = (double)sum / jaggedArray[i].Length;
            }
            Console.WriteLine("Среднее значение в каждой строке:"); // Вывод средних значений в каждой строке
        }
    }
}
