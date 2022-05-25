// 28. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число N");
//int n = int.Parse(Console.ReadLine());
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Неверный формат ввода, введите число");
}


int Factorial(int a)
{
    if (a == 1) return 1;
    else return Factorial(a - 1) * a;
}

/*int Mult(int l)
{
    int mult = 1;
    if (l > 0)
    {
        for (int i = 1; i <= l; i++)
        {
            mult *= i;
        }
    }
    else mult = 0;

    return mult;

}


void PrintMult(int m)
{
    if (m > 0)
    {
        for (int i = 1; i <= m; i++)
        {
            Console.Write($"{i} ");
        }
    }
    else
    {
        for (int j = 1; j >= m; j--)
        {
            Console.Write($"{j} ");
        }
    }

    Console.WriteLine();

}*/


void PrintMult(int m)
{

    for (int i = 1; i <= m; i++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

Console.Write("Числа от 1 до N: ");
PrintMult(n);
//Console.WriteLine("Произведение этих чисел равно: " + Mult(n));
Console.WriteLine("Произведение этих чисел равно: " + Factorial(n));