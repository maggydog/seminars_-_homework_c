// 23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

if (n == 0)
{
    Console.WriteLine("0 нам не очень подходит, введите число побольше: ");
    n = int.Parse(Console.ReadLine());
}

if (n < 0) n = -n;

//Console.WriteLine($"{i}^2 = {i*i}");
void SquareTable(int m)
{
    for (int i = 1; i <= m; i++) Console.Write($"{i} \t");
    Console.WriteLine();
    for (int j = 1; j <= m; j++) Console.Write($"{j * j} \t");
}


SquareTable(n);