// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Первое число:"+a);
Console.WriteLine("Второе число:"+b);
if(a>b)
{
    Console.WriteLine("Первое число больше второго");
}
else if(a<b)
{
    Console.WriteLine("Второе число больше первого");
}
else
{
    Console.WriteLine("Числа равны");
}
