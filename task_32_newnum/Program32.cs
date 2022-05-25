// 34. Написать программу замену элементов массива на противоположные

void FillAndPrint(int[] arr, int minValue, int maxValue)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(minValue,maxValue+1);
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

int[] array = new int [6];
FillAndPrint(array, -10, 10);
Console.WriteLine();
Change(array);