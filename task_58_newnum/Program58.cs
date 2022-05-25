// 58. Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int k = InputNumbers("Зададим первую матрицу. Введите количество строк: ");
int l = InputNumbers("Введите количество столбцов: ");
int m = InputNumbers("Зададим вторую матрицу. Введите количество строк: ");
int n = InputNumbers("Введите количество столбцов: ");
if (l != m)
{
    k = InputNumbers("Чтобы посчитать произведение, количество столбцов первой матицы должно совпадать с количеством строк второй. Введите количество строк первой матицы: ");
    l = InputNumbers("Введите количество столбцов: ");
    m = InputNumbers("Зададим вторую матрицу. Введите количество строк: ");
    n = InputNumbers("Введите количество столбцов: ");
}
int[,] tableA = new int[k, l];
int[,] tableB = new int[m, n];


int InputNumbers(string b)
{
    int a;
    Console.Write(b);
    while (!int.TryParse(Console.ReadLine(), out a) || a <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
    return a;
}

void FillAndPrintTable(int[,] array)
{
    int start = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = start + j; //для упрощенной проверки
                                     // array[i, j] = new Random().Next(0, 11);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMult(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
            for (int k = 0; k < secondArray.GetLength(0); k++)
                result[i, j] += firstArray[i, k] + secondArray[k, j];
    return result;            
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

FillAndPrintTable(tableA);
Console.WriteLine();
FillAndPrintTable(tableB);
Console.WriteLine();
int[,] tableC = MatrixMult(tableA, tableB);
PrintArray(tableC);