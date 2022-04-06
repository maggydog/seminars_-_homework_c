// 28. Подсчитать сумму цифр в числе
Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine());

void Sum (int n)
{
    int sum = 0;
    while (n>0)
    {
        sum=sum+n%10;
        n=n/10;
    }
Console.WriteLine($"Сумма цифр числа = {sum}");
}

Sum(a);