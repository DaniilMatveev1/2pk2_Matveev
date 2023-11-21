namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вывести  на экран построчно целые числа на указанном диапазоне.
            Console.WriteLine("1 задание ");

            for (int i = -50; i <= 50; i += 10)
            {
                Console.WriteLine(i);
            }
            //  вывести на экран в одну строку n символ а алфавитном порядке.
            Console.WriteLine("2 задание ");

            for (int n = 0; n <= 7; n++)
            {
                if (n == 0)
                    Console.WriteLine("O");
                else if (n == 1)
                    Console.WriteLine("P");
                else if (n == 2)
                    Console.WriteLine("Q");
                else if (n == 3)
                    Console.WriteLine("R");
                else if (n == 4)
                    Console.WriteLine("S");
                else if (n == 5)
                    Console.WriteLine("T");
                else if (n == 6)
                    Console.WriteLine("U");
            }
            // вывести на экран посимвольно n знаком # в m строках.
            Console.WriteLine(" 3 задание ");

            int v = 3;
            int m = 7;
            String b = "#";
            for (int i = 1; i <= m; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(b, v)));


            }
            // из деапозона значение вывести на экран вывести значеине кратных чисел.
            Console.WriteLine();
            Console.WriteLine(" 4 задание ");
            int sum = 0;
            for (int q = -500; q <= 300; q++)
            {
                if (q % 12 == 0)
                {
                    Console.Write($" {q}");
                    sum++;
                }
            }
            // выводить на экран значение двух переменных i и j , на каждом шаге интеграции одну переменную инкрементировать, а вторую декрементировать.
            Console.WriteLine();
            Console.WriteLine(" 5 задание ");
            for (int i = 3, j = 50; j - i > 14; i++, j--)
            {
                Console.WriteLine($"i = {i}, j = {j}");

            }










        }


    }
}









