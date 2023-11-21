namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = RemoveDuplicates(input);
            Console.WriteLine(result);
        }
        static string RemoveDuplicates(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                // Проверяем, что текущий символ не является пробелом
                if (input[i] != ' ')
                {
                    // Проверяем, что текущий символ не повторяется с предыдущим
                    if (i == 0 || input[i] != input[i - 1])
                    {
                        result += input[i];
                    }
                }
            }

            return result;
        }
    }
}
