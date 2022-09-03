Console.WriteLine("Введите число к1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число к2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());



double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;


Console.Write($"Координаты точки пересечения прямых: ({x}, {y})");