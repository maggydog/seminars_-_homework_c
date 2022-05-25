// 57. Составить частотный словарь элементов двумерного массива. 
/// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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
   
    
