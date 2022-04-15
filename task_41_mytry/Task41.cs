// 41. Выяснить являются ли три числа сторонами треугольника 
void TriangleSide (int a, int b, int c)
{
    if (a+b>c && b+c>a && a+c>b) Console.WriteLine ("Числа являются сторонами треугольника");
    else Console.WriteLine ("Числа не являются сторонами треугольника");
}

Console.WriteLine ("Введите первое число: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int l = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int m = int.Parse(Console.ReadLine());
TriangleSide (k, l, m);