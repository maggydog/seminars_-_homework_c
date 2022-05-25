// 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. 
//Длина массива задается с терминала.

Console.WriteLine("Какой будет длина массива? Введите число: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Неверный формат ввода, введите число: ");
}
int[] array = new int[n];


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Элемент [{i}] = {arr[i]}");
    }
}

int CountEven(int[] ar)
{
    int count = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0) count++;
    }
    return count;
}

int CountOdd(int[] a)
{
    int score = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 != 0) score++;
    }
    return score;
}



FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В этом массиве {CountEven(array)} четных чисел и {CountOdd(array)} нечетных");
//Console.WriteLine($"В этом массиве {CountEven(array)} четных чисел и {array.Length - CountEven(array)} нечетных чисел");
