﻿// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quadrant = int.Parse(Console.ReadLine());


/*void Coordinates(int x)
{
    while (x < 1 || x > 4)
    {
        Console.WriteLine("В нашей плоскости всего 4 четверти, введи число от 1 до 4");
        x = int.Parse(Console.ReadLine());
    }

    if (x == 1) Console.WriteLine("В первой четверти плоскости располагаются точки со значениями по оси x : (0;+бесконечность), по оси y (0;+бесконечность)");
    else if (x == 2) Console.WriteLine("Во второй четверти плоскости располагаются точки со значениями по оси x : (0;-бесконечность), по оси y (0;+бесконечность)");
    else if (x == 3)Console.WriteLine("В третьей четверти плоскости располагаются точки со значениями по оси x : (0;-бесконечность), по оси y (0;-бесконечность)");
    else if (x == 4) Console.WriteLine("В четвертой четверти плоскости располагаются точки со значениями по оси x : (0;+бесконечность), по оси y (0;-бесконечность)");
}

Coordinates(quadrant);*/

//через возврат строки

  while (quadrant < 1 || quadrant > 4)
    {
        Console.WriteLine("В нашей плоскости всего 4 четверти, введи число от 1 до 4");
        quadrant = int.Parse(Console.ReadLine());
    }

string Coordinates(int x)
{
    if (x == 1) return "В первой четверти плоскости располагаются точки со значениями по оси x : (0;+бесконечность), по оси y (0;+бесконечность)";
    if (x == 2) return "Во второй четверти плоскости располагаются точки со значениями по оси x : (0;-бесконечность), по оси y (0;+бесконечность)";
    if (x == 3)return "В третьей четверти плоскости располагаются точки со значениями по оси x : (0;-бесконечность), по оси y (0;-бесконечность)";
    if (x == 4) return "В четвертой четверти плоскости располагаются точки со значениями по оси x : (0;+бесконечность), по оси y (0;-бесконечность)";
    return "Введите значение от 1 до 4";
}

Console.WriteLine (Coordinates(quadrant));
