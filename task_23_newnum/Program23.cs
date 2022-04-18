// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableCube(int b)
{
    if (b > 0)
    {
        //for (int i = 1; i <= a; i++) Console.WriteLine($"{i}^3 = {i * i * i}");
        for (int i = 1; i <= b; i++) Console.Write($"{i} \t");
        Console.WriteLine();
        for (int j = 1; j <= b; j++) Console.Write($"{j * j * j} \t");
    }
    else
    {
        for (int i = 1; i >= b; i--) Console.Write($"{i} \t");
        Console.WriteLine();
        for (int j = 1; j >= b; j--) Console.Write($"{j * j * j} \t");
    }
}

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
TableCube(n);

/*void Cube(int a)
{
    if (a > 0)
    {
        for (int i = 1; i <= a; i++) Console.WriteLine($"{i}^3 = {i * i * i}");
    }
    else
    {
        for (int j = 1; j >= a; j--) Console.WriteLine($"{j}^3 = {j * j * j}");
    }
}*/