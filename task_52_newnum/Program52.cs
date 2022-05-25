// 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


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

// вариант 1 без доп.переменной. 

void AverageInColumns(int[,] array)
{
    double sum = 0;

    for (int i = 0; i < array.GetLength(1); i++) //переворачиваем счетчик, чтобы идти по столбцу вниз
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое чисел в столбце {i}: {sum} / {array.GetLength(0)} = {sum / array.GetLength(0)}");
        sum = 0;
    }
}


// вариант 2 с доп.переменной average

void AverageInColumns2(int[,] arr)
{
    double average = 0;
    double sum = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        average = sum / arr.GetLength(0);
        //тут округлим результат до 1 цифры после запятой
        Console.WriteLine($"Среднее арифметическое чисел в столбце {i}: {sum} / {arr.GetLength(0)} = {Math.Round(average, 1)}");
        sum = 0;
    }
}

FillAndPrintTable(table);
AverageInColumns(table);
Console.WriteLine();
AverageInColumns2(table);