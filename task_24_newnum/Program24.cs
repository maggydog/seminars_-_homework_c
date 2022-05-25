// 24. Найти сумму чисел от 1 до А

Console.WriteLine ("Введите число A");
//int a = int.Parse(Console.ReadLine());
int a;
while (!int.TryParse(Console.ReadLine(), out a) || a<1)
{
    Console.WriteLine ("Вы ввели неверный формат числа, попробуйте снова. Введите положительное целое число:");
}


int Sum (int n)
{
return (n*(n+1))/2;
}

/*int Sum (int n)
{
    int sum=0;
    for(int i = 0; i<=n;i++)
    {
        sum=sum+i;
    }
    return sum;
}
*/

void PrintNumbers (int m)
{
    for (int i = 1; i <=m; i++)
    {
        Console.Write ($"{i} ");
    }
Console.WriteLine();    
}

Console.Write ("Числа от 1 до A: ");
PrintNumbers(a);
Console.WriteLine("Сумма этих чисел равна: " + Sum(a));
