// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int m;
while (!int.TryParse(Console.ReadLine(), out m) || m <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
Console.WriteLine("Введите количество столбцов: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");

double[,] table = new double[m, n];

void FillArrayWithRealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble();

}

void PrintArray(double[,] array)
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

FillArrayWithRealNumbers(table);
PrintArray(table);