// Написать программу вычисления значения функции y = f(a)
int f (int a)
{
    int y = a;
    return y;
}
int f2 (int a)
{
    int y2 = a*a;
    return y2;
}

int f3 (int a)
{
    int y3 = a*a*a;
    return y3;
}

Console.WriteLine ("Введите число для наших функций: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Посмотрим, чему равна функция y=f(a), где f(a)=a: "+ f(a));
Console.WriteLine ("Посмотрим, чему равна функция y=f(a), где f(a)=a^2: "+f2(a));
Console.WriteLine ("Посмотрим, чему равна функция y=f(a), где f(a)=a^3: "+f3(a));