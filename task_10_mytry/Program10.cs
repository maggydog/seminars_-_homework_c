//10.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Second(int b)
{
    return b / 10 % 10;
}

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

while (a < 100 && a > -100 || a > 999 || a < -999)
{
    Console.WriteLine("Нам все же нужно трехзначное число, введите его: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Вы ввели число: " + a);
}

if (99 < a && a < 1000) Console.WriteLine($"Теперь выведем вторую цифру этого числа: {Second(a)}");

else Console.WriteLine($"Теперь выведем вторую цифру этого числа: {-Second(a)}");



