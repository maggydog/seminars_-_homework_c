// 25. Найти сумму чисел от 1 до А

Console.WriteLine ("Введите число A");
int a = int.Parse(Console.ReadLine());
int Sum (int n)
{
return (n*(n+1))/2;
}

void PrintSum (int m)
{
    for (int i = 1; i <=m; i++)
    {
        Console.Write ($"{i} ");
    }
Console.WriteLine();    
}
Console.Write ("Числа от 1 до A: ");
PrintSum(a);
Console.WriteLine("Сумма этих чисел равна: " + Sum(a));