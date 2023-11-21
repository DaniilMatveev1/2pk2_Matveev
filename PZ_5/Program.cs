namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); // Дано целое число N (> 0). Найти наименьшее целое положительное число K, квадрат которого превосходит N
            int N = 100;
            int K = 0;
            while (K * K <= N)
            {// пока квадрат К не привышает заданное числo N}
                K++; // увеличиваем К
            }
            K--; // уменьшаем К
            Console.WriteLine(K); // выводим результат
        }

    }
}