double x, y, z;
int m;
double n;

// Ввод данных
Console.WriteLine("Введите m:");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x:");
x = Convert.ToDouble(Console.ReadLine());

// Вычисление значения x
if (m > 5)
{
    x = (m + n);
}
else
{
    x = Math.Sqrt(n + 5) * (m * Math.Pow(n, 2) - (2.1 * n));
}

// Вычисление значения y
if (x <= 0)
{
    y = Math.Log(m * n + x);
}
else
{
    y = Math.Cos(m * x) * Math.Sin(n * x);
}

// Вычисление значения z
z = (2 * x + 3 * y) / (Math.Pow(m, 2) + 5);

// Вывод результатов
Console.WriteLine("Значение x: " + x);
Console.WriteLine("Значение y: " + y);
Console.WriteLine("Значение z: " + z);








