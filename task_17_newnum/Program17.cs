// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите координату x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y");
double y = double.Parse(Console.ReadLine());

int GetQuadrant (double a, double b)
{
    if (a>0 && b>0) return 1; /* без else, тк return прекращает программу*/
    if (a<0 && b>0) return 2;
    if (a<0 && b<0) return 3;
    if (a>0 && b<0) return 4;
    return 0;
}    

Console.WriteLine($"Точка находится в {GetQuadrant(x,y)} квадранте");
/*
if (x>0 && y>0) Console.WriteLine($"Точка с координатами ({x},{y}) находится в первой четверти плоскости");
else if (x<0 && y>0) Console.WriteLine($"Точка с координатами ({x},{y}) находится во второй четверти плоскости");
else if (x<0 && y<0) Console.WriteLine($"Точка с координатами ({x},{y}) находится в третьей четверти плоскости");
else if (x>0 && y<0) Console.WriteLine($"Точка с координатами ({x},{y}) находится в четвертой четверти плоскости");
else Console.WriteLine ("Эта точка лежит на одной из осей или на их пересечени, чтобы определить точку, расположенную в одной из четвертей - введи пару координат, отличных от 0");*/