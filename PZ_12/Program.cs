namespace PZ_12;

internal class Program
{
   static bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку");
        string str1 = Console.ReadLine();
        Console.WriteLine("Введите следующую строку");
        string str2 = Console.ReadLine();
        if (CompareStrings(str1, str2))
        {
            Console.WriteLine("Равные строки");
        }
        else
        {
            Console.WriteLine("Не равные строки");
        }
    }
}
