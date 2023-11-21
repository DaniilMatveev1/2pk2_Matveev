namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int i, j; // индекс массива
            int[,] A = new int[3, 3];
            Console.WriteLine(" Массив А: ");
            Random rnd = new Random();
            for (i = 0; i <= 3; i++) // сначало строки
            {
                for (j = 0; j <= 3; j++)
                {
                    A[i, j] = i + 3 * j + 1;
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine($"длина массива - количество элементов: {A.Length}");
            }

            Console.ReadLine();
        }
    }
}