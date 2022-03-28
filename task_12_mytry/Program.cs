// 12. Удалить вторую цифру трёхзначного числа
int First (int x)
{
    int digit = x/100;
    return digit;
}
int Second (int y)
{
    int digit = y/10;
    return digit%10;
}
int Third (int z)
{
    return z%10;
}

Console.WriteLine ("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число: "+a);
int step = 0;

while (step<=100)
{
    if ( a/1000==0 & a/100 > 0)
    {
        Console.WriteLine("Теперь выведем первую и третью цифру этого числа: "+ First(a) + Third(a));
        break;
    }
    else
    {
        Console.WriteLine("Нам все же нужно трехзначное число, введите его: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы ввели число: "+a);
    }
    step++;
}
