﻿// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координату x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y");
double y = double.Parse(Console.ReadLine());
if (x>0 && y>0) Console.WriteLine($"Точка с координатами ({x},{y}) находится в первой четверти плоскости");
else if (x<0 && y>0) Console.WriteLine($"Точка с координатами ({x},{y}) находится во второй четверти плоскости");
else if (x<0 && y<0) Console.WriteLine($"Точка с координатами ({x},{y}) находится в третьей четверти плоскости");
else if (x>0 && y<0) Console.WriteLine($"Точка с координатами ({x},{y}) находится в четвертой четверти плоскости");
else Console.WriteLine ("Эта точка лежит на одной из осей или на их пересечени, чтобы определить точку, расположенную в одной из четвертей - введи пару координат, отличных от 0");