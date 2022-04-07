// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillAndPrint(double[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = new Random(). NextDouble();
        //arr [i] = i+1;
        //arr [i] = new Random(). Next (1,10);
        Console.Write ($"{arr[i]}\t");
    }
}

double FindMax (double[]ar)
{
    //int mult=0;
    int i=0;
    double max = ar[i];
    for (i=0; i<ar.Length-1; i++)
    {
       if (max<ar[i+1]) max=ar[i+1]; 
    }
    return max;
}

double FindMin (double[]ar)
{
    //int mult=0;
    int j=0;
    double min = ar[j];
    for (j=0; j<ar.Length-1; j++)
    {
       if (min>ar[j+1]) min=ar[j+1];
    }
    return min;
}

double[] array = new double [8];
FillAndPrint(array);
Console.WriteLine();
Console.WriteLine($"Максимальное число массива: {FindMax(array)}, минимальное число массива: {FindMin(array)}, произведение этих чисел: {FindMax(array) * FindMin(array)}");
