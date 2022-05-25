// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Вверите коэф. b1 для первого уравнения: ");
double b1;
while (!double.TryParse(Console.ReadLine(), out b1)) Console.WriteLine($"Ошибка ввода.Введите число.");
Console.WriteLine("Вверите коэф. k1 для первого уравнения: ");
double k1;
while (!double.TryParse(Console.ReadLine(), out k1)) Console.WriteLine($"Ошибка ввода.Введите число.");
Console.WriteLine("Вверите коэф. b2 для второго уравнения: ");
double b2;
while (!double.TryParse(Console.ReadLine(), out b2)) Console.WriteLine($"Ошибка ввода.Введите число.");
Console.WriteLine("Вверите коэф. k2 для второго уравнения: ");
double k2;
while (!double.TryParse(Console.ReadLine(), out k2)) Console.WriteLine($"Ошибка ввода.Введите число.");

void CrossPointCoordinates(double a, double b, double c, double d) // y=ax+c,y=bx+d
{
    double x = (d - c) / (a - b);
    //if (a == b) x = 0;
    double y = a * x + c;
    Console.WriteLine($"Точнка пересечения прямых ({x},{y})");
}


if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают");
else if (b1 != b2 && k1 == k2) Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
else CrossPointCoordinates(k1, k2, b1, b2);


