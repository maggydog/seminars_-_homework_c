// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int [] array = new int[12];

void FillArray (int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index<length)
    {
        arr[index]=new Random(). Next (0,10);
        index++;
    }
}

void PrintArray (int[] ar)
{
    int l = ar.Length;
    int position = 0;
    while (position<l)
    {
        Console.Write($"{ar[position]} ");
        position++;
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
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumArray(array);