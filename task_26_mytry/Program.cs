// 26. Возведите число А в натуральную степень B используя цикл
Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Укажите степень, в которую Вы хотите возвести число: ");
int b = int.Parse(Console.ReadLine());

int Step(int m,int n)
{
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        result = result * m;
    }
return result;
}

Console.WriteLine(Step(a,b));