// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int [] array = new int[12];

/*void FillArray (int[] arr)

{
    for (int i=0; i<arr.Length;i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
}*/
void FillArray (int[] arr, int minValue, int maxValue)

{
    Random random = new Random ();
    for (int i=0; i<arr.Length;i++)
        arr[i] = random.Next(minValue, maxValue+1);
    
}


void PrintArray (int[] arr)

{
    for (int i=0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SumArray (int[] a)
{
    int sum = 0;
    for (int i=0; i<a.Length; i++)
    {
        sum=sum+a[i];
    }
    Console.WriteLine($"Сумма чисел массива равна {sum}");
}

void SumOfPositiveArray (int[] a)
{
    int sum = 0;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]>0) sum=sum+a[i];
    }
    Console.WriteLine($"Сумма положительных чисел массива равна {sum}");
}

void SumOfNegativeArray (int[] a)
{
    int sum = 0;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]<0) sum=sum+a[i];
    }
    Console.WriteLine($"Сумма отрицательных чисел массива равна {sum}");
}

FillArray(array, -9, 9);
PrintArray(array);
Console.WriteLine();
SumArray(array);
SumOfPositiveArray(array);
SumOfNegativeArray(array);