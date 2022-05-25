// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали.


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
            array[i, j] = start;
            Console.Write($"{array[i, j]} \t");
            start++;
        }
        Console.WriteLine();
    }
}

void FindAndSumDiagonalElements(int[,] array, int a, int b)
{
    int sum = 0;

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            if (i == j) sum = sum + array[i, j];
    Console.WriteLine(sum);
    /*for (int i = 0; i < a; i++)
    {
        int j = i;
        sum = sum + table[i, j];
    }
    Console.WriteLine(sum);*/
}



FillArrayInARow(table, m, n);
Console.WriteLine();
FindAndSumDiagonalElements(table, m, n);
