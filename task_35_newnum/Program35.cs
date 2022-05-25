// 35. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillAndPrintInOrder(int[] arr)
{
    int n = 0;
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = i+1;
        Console.Write ($"{arr[i]}\t");
    }
}

void FillArray (int[] arr)

{
    Random random = new Random ();
    for (int i=0; i<arr.Length;i++)
        arr[i] = random.Next();
    
}


void PrintArray (int[] arr)

{
    for (int i=0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int FindSegment (int[]ar)
{
    int count = 0;
    for (int i=0; i<ar.Length; i++)
    {
        if (ar[i]>=9 && ar[i]<=100) count++;
    }
    return count;
}

int FindSegmentCommon (int[]ar, int minLimit, int maxLimit)
{
    int count = 0;
    for (int i=0; i<ar.Length; i++)
    {
        if (ar[i]>=minLimit && ar[i]<=maxLimit) count++;
    }
    return count;
}


int[] array = new int [123];

//FillArray(array);
//PrintArray(array);
FillAndPrintInOrder(array);
Console.WriteLine();
Console.WriteLine (FindSegmentCommon (array, 10, 99));
//Console.WriteLine (FindSegment (array));
/*Console.WriteLine();
Console.WriteLine($"В этом массиве {FindEven(array)} четных чисел и {FindOdd(array)} нечетных чисел");
Console.WriteLine($"В этом массиве {FindEven(array)} четных чисел и {array.Length - FindEven(array)} нечетных чисел");*/
