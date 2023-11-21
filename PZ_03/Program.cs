namespace PZ_03
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string caseSwitch = Console.ReadLine(); // программа которая в зависимости от характера ветра выдает сообщение о его скорости.

            switch (caseSwitch)
            {
                case "слабый":
                    Console.WriteLine("слабый (1-4 м/с)"); // сильный ветер
                    break;
                case "умеренный":
                    Console.WriteLine("умеренный (5-10 м/с)"); // умеренный ветер
                    break;
                case "сильный":
                    Console.WriteLine("сильный (11-18 м/с)"); // сильный ветер
                    break;
                case "ураган":
                    Console.WriteLine("ураган (больше 19 м/с)"); // ураган
                    break;
                default:
                    Console.WriteLine("неверно указано"); // не одно из условий не подошло
                    break;
            }
        }
    }
}
