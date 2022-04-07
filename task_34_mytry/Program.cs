// 34. Написать программу замену элементов массива на противоположные

void FillAndPrint(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(-5,5);
        Console.Write ($"{arr[i]}\t");
    }
}

void Change (int[] ar)
{
    for (int n = 0; n<ar.Length; n++)
    {
        ar[n]=ar[n]*-1;
        Console.Write ($"{ar[n]}\t");
    }
}

int[] array = new int [10];
FillAndPrint(array);
Console.WriteLine();
Change(array);