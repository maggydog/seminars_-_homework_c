// 22. Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координату x первой точки");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int bz = int.Parse(Console.ReadLine());
//int l = (bx-ax)*(bx-ax) + (by-ay)*(by-ay);
//double l = Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay));

Console.WriteLine($"Длина отрезка между первой ({ax},{ay}) и второй ({bx},{by}) точкой равна { Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay))}");
Console.WriteLine($"Длина отрезка между первой ({ax},{ay},{az}) и второй ({bx},{by},{bz}) точкой равна { Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay)+ (bz-az)*(bz-az))}");