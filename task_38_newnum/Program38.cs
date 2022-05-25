// 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным значением элементов массива. 
//Длина массива задается с терминала.

Console.WriteLine("Какой будет длина массива? Введите число: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Неверный формат ввода, введите число: ");
}
double[] array = new double[n];


void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Элемент [{i}] = {arr[i]}");
    }
}

double FindMax(double[] arr)
{
    int i = 0;
    double max = arr[i];
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double FindMin(double[] arr)
{
    int i = 0;
    double min = arr[i];
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min) min = arr[i];
    }
    return min;
}


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент: {FindMax(array)}");
Console.WriteLine($"Минимальный элемент: {FindMin(array)}");
Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива: {FindMax(array)-FindMin(array)}");

