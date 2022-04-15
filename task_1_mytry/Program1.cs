// По двум заданным числам проверить является ли первое квадратом второго, является ли второе квадратом первого
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a==b*b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if(b==a*a)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}