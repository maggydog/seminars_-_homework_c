// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки, в которой находится элемент: ");
int m;
while (!int.TryParse(Console.ReadLine(), out m) || m < 0) Console.WriteLine("Ошибка ввода. Введите 0 или положительное число:");
Console.WriteLine("Введите номер столбца, в котором находится элемент: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n < 0) Console.WriteLine("Ошибка ввода. Введите 0 или положительное число:");

int[,] table = new int[5, 5];


void FillArrayInARow(int[,] array) //заполняю числами подряд для упрощения проверки
{
    int start = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = start;
            start++;
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

//Вариант, когда человек знает, что нумерация координат ячеек идет с 0.

void FindElementInTable(int[,] array, int a, int b)
{

    if (a < array.GetLength(0) && b < array.GetLength(1))
        Console.WriteLine($"В ячейке с координатами ({a},{b}) находится число {array[a, b]}");
    else Console.WriteLine($"Ячейки с координатами ({a}, {b}) нет в таблице");
}

FillArrayInARow(table);
PrintArray(table);
Console.WriteLine();
FindElementInTable(table, m, n);

//вариант, когда человек НЕ знает, что нумерация с 0 и по анлогии с экселем первая ячейка (1,1(a)), а не (0,0).
// Для этого случая при вводе координат нужно ввести проверку на 0, чтобы ввод был только с 1.

Console.WriteLine();
Console.WriteLine("Вариант для пользователей, которые привыкли, что нумерация начинается с 1");
Console.WriteLine("Введите номер строки, в которой находится элемент: ");
int k;
while (!int.TryParse(Console.ReadLine(), out k) || k <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");
Console.WriteLine("Введите номер столбца, в котором находится элемент: ");
int l;
while (!int.TryParse(Console.ReadLine(), out l) || l <= 0) Console.WriteLine("Ошибка ввода. Введите положительное число:");

int[,] tableLikeExcel = new int[3, 3];

void FindElementInTable2(int[,] array, int a, int b)
{

    if (a - 1 < array.GetLength(0) && b - 1 < array.GetLength(1))
        Console.WriteLine($"В ячейке с координатами ({a},{b}) находится число: { array[a - 1, b - 1] }");
    else Console.WriteLine($"Ячейки с координатами ({a}, {b}) нет в таблице");
}

FillArrayInARow(tableLikeExcel);
PrintArray(tableLikeExcel);
Console.WriteLine();
FindElementInTable2(tableLikeExcel, k, l);
