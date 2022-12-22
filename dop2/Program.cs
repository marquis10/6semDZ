Console.Clear();
Console.WriteLine("Введите координаты вершин треугольника (x1, y1), (x2, y2), (x3, y3): ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int x1 = array[0], y1 = array[1], x2 = array[2], y2 = array[3], x3 = array[4], y3 = array[5], 
AB = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))), 
BC = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))), 
AC = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2))), 
P = (AB+BC+AC)/2, 
S = Convert.ToInt32(Math.Sqrt(P*(P-AB)*(P-BC)*(P-AC)));
Console.WriteLine($"Длина стороны AB = {AB}\nДлина стороны BC = {BC}\nДлина стороны AC = {AC}\nПроизведение полупериметра = {P}\nПлощадь треугольника по формуле Герона = {S}");