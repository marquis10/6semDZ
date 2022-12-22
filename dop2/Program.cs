Console.Clear();
Console.WriteLine("Введите координаты вершин треугольника (x1, y1), (x2, y2), (x3, y3): ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int x1 = array[0], y1 = array[1], x2 = array[2], y2 = array[3], x3 = array[4], y3 = array[5];

int AB = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(x1 - x2, 2)), 2));
int BC = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(x2 - x3, 2)), 2));
int AC = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(x1 - x3, 2)), 2));
int P = Convert.ToInt32((AB+BC+AC)/2);
int S = Convert.ToInt32(Math.Round(Math.Sqrt(P*(P-AC)*(P-BC)*(P-AC))));
Console.WriteLine(S);

/*
Console.Clear();
Console.WriteLine("Введите координаты вершин треугольника (x1, y1), (x2, y2), (x3, y3): ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int x1 = array[0], y1 = array[1], x2 = array[2], y2 = array[3], x3 = array[4], y3 = array[5];
Console.WriteLine($"Длина стороны AB = {Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(x1 - x2, 2)), 2)}");
int AB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Длина стороны BC = {Math.Round(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(x2 - x3, 2)), 2)}");
int BC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Длина стороны AC = {Math.Round(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(x1 - x3, 2)), 2)}");
int AC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение полупериметра = {(AB+BC+AC)/2}");
int P = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Площадь треугольника по формуле Герона = {Math.Round(Math.Sqrt(P*(P-AC)*(P-BC)*(P-AC)))}");
int S = Convert.ToInt32(Console.ReadLine());
*/