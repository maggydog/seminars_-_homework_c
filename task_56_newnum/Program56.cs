// 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = InputNumbers("Зададим прямоугольную матрицу. Введите количество строк: ");
int n = InputNumbers("Введите количество столбцов: ");
if (m == n)
{
    m = InputNumbers("В пряумогльной матрице число строк и столбцов должно различаться. Введите количество строк: ");
    n = InputNumbers("Введите количество столбцов: ");
}

int[,] table = new int[m, n];

int InputNumbers(string b)
{
    int a;
    Console.Write(b);
    while (!int.TryParse(Console.ReadLine(), out a) || a <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
    return a;
}

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

// Вывод сумм строк в одномерный массив

int[] RowSumIntoNewArray(int[,] array)
{
    int sum = 0;
    int[] newarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        newarray[i] = sum;

        sum = 0;
    }
    return newarray;
}


// Ищем минимум в одномерном массиве сумм. 

void FindMinInArray(int[] arr)
{
    int minPosition = 0;
    int i = 1;
    for (i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minPosition]) minPosition = i;
    }

    Console.WriteLine($"Строка с минимальной суммой элементов: {minPosition}");
    for (int j = 0; j < arr.Length; j++)
    {
        if (j != minPosition && arr[j] == arr[minPosition]) Console.WriteLine($"Еще одна строка с минимальной суммой элементов: {j}");
    }
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Элемент [{i}] = {arr[i]}");
    }
}

FillAndPrintTable(table);
Console.WriteLine();
int[] sumarray = RowSumIntoNewArray(table);
Console.WriteLine("Одномерный массив сумм чисел из строк таблицы:");
PrintArray(sumarray);
Console.WriteLine();
FindMinInArray(sumarray);
