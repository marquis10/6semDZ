Console.Clear();
Console.WriteLine("Введите координаты 2 прямых b1, k1, b2, k2:");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0, y = 0;
if (b1 == b2 && k1 == k2)
    Console.WriteLine("Прямые совпадают");
else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны и не пересекутся, т.к. k1 = k2");
    }
else
    Console.WriteLine($"Точка пересечения двух прямых произойдёт в координате: X = {x = (b2 - b1) / (k1 - k2)}\nY = {y = k1 * x + b1}");