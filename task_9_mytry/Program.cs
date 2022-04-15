//9. Показать последнюю цифру трёхзначного числа
int Last(int a)
{
    int digit = a % 10;
    return digit;
}
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число: " + a);
int step = 0;

while (step <= 100)
{
    if (a / 1000 == 0 & a / 100 > 0)
    {
        Console.WriteLine("Теперь выведем последнюю цифру числа " + a);
        int dig = Last(a);
        Console.WriteLine(dig);
        break;
    }
    else
    {
        Console.WriteLine("Нам все же нужно трехзначное число, введите его: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы ввели число: " + a);
    }
    step++;
}