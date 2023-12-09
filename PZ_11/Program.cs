namespace PZ_11
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            InputValues(out x, out y);
            int sum = CalculateSum(x, y);
            PrintResult(sum);
        }

        static void InputValues(out int x, out int y)
        {
            Console.WriteLine("Введите первое целое число:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine($"Ответ: {result}");
        }
    }
}
