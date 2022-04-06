// 29. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine ("Введите число N");
int n = int.Parse(Console.ReadLine());
int Mult (int l)
{
    int mult = 1;
    for (int i = 1; i<=l; i++)
    {
        mult=mult*i;
    }
return mult;
}

void PrintMult (int m)
{
    for (int i = 1; i <=m; i++)
    {
        Console.Write ($"{i} ");
    }
Console.WriteLine();    
}

Console.Write ("Числа от 1 до N: ");
PrintMult(n);
Console.WriteLine("Произведение этих чисел равно: " + Mult(n));