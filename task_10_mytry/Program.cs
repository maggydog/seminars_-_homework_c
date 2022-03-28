//10. Показать вторую цифру трёхзначного числа
int Second (int b)
{
    int digit = b/10;
    return digit%10;
}
Console.WriteLine ("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число: "+a);
int step = 0;

while (step<=100)
{
    if ( a/1000==0 & a/100 > 0)
    {
        Console.WriteLine("Теперь выведем вторую цифру этого числа: "+Second(a));
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