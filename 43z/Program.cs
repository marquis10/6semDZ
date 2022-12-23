Console.Clear();
Console.WriteLine("Введите координаты 2 прямых b1, k1, b2, k2:");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0, y = 0;
Console.WriteLine($"X = {x = (b2 - b1) / (k1 - k2)}\nY = {y = k1 * x + b1}");