// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты.

Console.WriteLine("Rows: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Colunms: ");
int n = int.Parse(Console.ReadLine());
int[,] table = new int[m, n];

void FillArrayInARow(int[,] array, int a, int b)
{
    int start = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            table[i, j] = start;
            Console.Write($"{table[i, j]} \t");
            start++;
        }
        Console.WriteLine();
    }
}

void FindEvenPositions(int[,] array, int a, int b)
{
    for (int i = 2; i < a; i=i+2)
    {
        for (int j = 2; j < b; j=j+2)
        {
            table[i, j] = table[i, j] * table[i, j];
        }
    }
}

void PrintArray (int[,] array, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($"{table[i, j]} \t");
        }
        Console.WriteLine();
    }
}


FillArrayInARow(table, m, n);
FindEvenPositions(table, m, n);
Console.WriteLine();
PrintArray(table, m, n);
