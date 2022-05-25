// 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. 
//Длина массива задается с терминала.

Console.WriteLine("Какой будет длина массива? Введите число: ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Неверный формат ввода, введите число: ");
}
int[] array = new int [n];


void FillArray (int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(); 
    }
}

void PrintArray (int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        Console.WriteLine ($"Элемент [{i}] = {arr[i]}");
    }
}

int SumOddPosition (int[]a)
{
    int sum = 0;
    for (int i=1; i<a.Length; i+=2)
    {
        sum+=a[i]; //без ограничения интервала чисел для наполнения массива получаются довольно большие числа, можно попробовать поменять тип с int на double, или long
    }
    return sum;
}



FillArray (array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {SumOddPosition(array)}");

