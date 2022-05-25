// 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
            array[i, j] = new Random().Next(-10, 11);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ChangeRowsAndColumns(int[,] arr)
{
    int temp = 0;
    int shift = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0 + shift; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    shift++;
    }
}

void ChangeRowsAndColumns2(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0)-1; i++) // выше главной диагонали
    {
        for (int j = i + 1; j < arr.GetLength(1); j++) //смещаем j на i+1
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    shift++;
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


if (m == n)
{
    FillAndPrintTable(table);
    ChangeRowsAndColumns(table);
    Console.WriteLine();
    PrintArray(table);
}
else Console.WriteLine("В таблице разное количество столбцов и строк, произвести замену не получится");