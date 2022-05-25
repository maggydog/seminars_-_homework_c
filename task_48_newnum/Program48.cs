// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4. 0 12 3 - 1 23 4  - 2 34 5

Console.WriteLine ("Rows: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Colunms: ");
int n = int.Parse(Console.ReadLine());

int[,] table = new int[m,n];
for (int i=0; i<m; i++)
{
    for (int j=0;j<n;j++)
    {
        table[i,j] = i+j;
        Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}