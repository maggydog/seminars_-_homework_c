// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.WriteLine ("Rows: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Colunms: ");
int n = int.Parse(Console.ReadLine());
int[,] table = new int[m,n];
/*for (int i=0; i<m; i++)
{
    for (int j=0;j<n;j++)
    {
        table[i,j] = new Random().Next ();
        Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}
*/

void FillTable (int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=rnd.Next(min,max);
}

void PrintTable (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            Console.WriteLine($"Значение ячейки ({i},{j}) = {array[i,j]}");
}

FillTable(table, -100, 100);
PrintTable(table);