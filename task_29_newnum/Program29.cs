// 29. Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит их на экран. Диапазон - любое целое число.

int [] array = new int[8];

void FillAndPrintArray (int[] arr)

{
    for (int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next();
        Console.Write($"{arr[i]} ");
    }
}

// если разнести на 2 метода:
void FillArray (int[] arr)

{
    for (int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next();
    }
}

void PrintArray (int[] arr)

{
    for (int i=0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

// пробуем все три метода:
FillAndPrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);