//  54. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.WriteLine("Введите количество строк: ");
int m;
while (!int.TryParse(Console.ReadLine(), out m) || m <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
Console.WriteLine("Введите количество столбцов: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");

int[,] table = new int[m, n];

void FillAndPrintTable(int[,] array)
{
    //int start = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i, j] = start + j; //для упрощенной проверки
            array[i, j] = new Random().Next(0, 11);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SortRowsMaxToMin(int[,] arr)
{
    
    int i = 0;
    int j = 0;
    for (i = 0; i < arr.GetLength(0); i++)
    {
        for (j = 0; j < arr.GetLength(1)-1; j++)
        {
            int maxColumn = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, maxColumn])
                    maxColumn = k;
                //Console.WriteLine($"{arr[i,minColumn]}");
            }

        int temp = arr[i, j];
        arr[i, j] = arr[i, maxColumn];
        arr[i, maxColumn] = temp;
        //Console.WriteLine();
        //PrintArray(arr);
        }
        
        
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

FillAndPrintTable(table);
SortRowsMaxToMin(table);
Console.WriteLine();
PrintArray(table);