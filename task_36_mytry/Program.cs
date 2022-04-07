// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillAndPrint(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(100,1000);
        Console.Write ($"{arr[i]}\t");
    }
}

int FindEven (int[]ar)
{
    int count = 0;
    for (int i=0; i<ar.Length; i++)
    {
        if (ar[i]%2==0) count++;
    }
    return count;
}

int FindOdd (int[]a)
{
    int score = 0;
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]%2 != 0) score++;
    }
    return score;
}


int[] array = new int [15];
FillAndPrint(array);
Console.WriteLine();
Console.WriteLine($"В этом массиве {FindEven(array)} четных чисел и {FindOdd(array)} нечетных чисел");
//Console.WriteLine($"В этом массиве {FindEven(array)} четных чисел и {array.Length - FindEven(array)} нечетных чисел");
