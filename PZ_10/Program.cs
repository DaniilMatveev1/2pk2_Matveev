namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "я студент второго курса.";
            string str2 = "я студент первого курса.";

            // Разбиваем строки на слова
            string[] words1 = str1.Split(' ');
            string[] words2 = str2.Split(' ');

            // Создаем новую строку, содержащую только уникальные слова из второй строки
            string result = "";
            foreach (string word in words2)
            {
                if (!str1.Contains(word))
                {
                    result += word + " ";
                }
            }

            // Выводим результат на консоль
            Console.WriteLine(str1);
            Console.WriteLine(result);
        }
    }
}
