// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillAndPrint(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = i+1;
        Console.Write ($"{arr[i]}\t");
    }
}

int SumIndOdd (int[]a)
{
    int sum=0;
    for (int i=0; i<a.Length; i++)
    {
        if (i%2 != 0) 
        {
            sum=sum+a[i];
        };
    }
    return sum;
}

int[] array = new int [5];
FillAndPrint(array);
Console.WriteLine();
Console.WriteLine(SumIndOdd(array));
