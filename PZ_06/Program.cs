namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); // заполнить массив из 10 случайныз числел в деапазоне от -10..10.
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };// случайные числа от -10 до 10
            int k = 9; // сдвиг, значеине переменной k
            int tmt;
            int nextInd = 0;
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 1; i < arr.Length - 0; i++)
            {
                nextInd += k;
                nextInd %= arr.Length;

                tmt = arr[nextInd];
                arr[nextInd] = arr[0];
                arr[0] = tmt;
            }
            Console.WriteLine(string.Join(' ', arr)); // вывод результата на экран



        }
    }
}
