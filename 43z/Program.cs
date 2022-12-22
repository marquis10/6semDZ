Console.Clear();
Console.WriteLine("Введите координаты 2 прямых k1, b1, k2, b2:");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int x = (b2 - b1) / (k1 - k2), y = 0;
