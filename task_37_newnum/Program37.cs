// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void FillAndPrint(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = i+1;
        Console.Write ($"{arr[i]}\t");
    }
}

void Print(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        Console.Write ($"{arr[i]}\t");
    }
}


/*void PairMult (int[]ar)
{
    //int mult=0;
    int j = ar.Length-1;
    for (int i=0; i<ar.Length/2; i++)
    {
       //mult = ar[i]*ar[j];
        Console.WriteLine($"Произведение пары: {ar[i]*ar[j]}");
        j--;
    }
    if (ar.Length%2 != 0) Console.WriteLine ($"В массиве нечетное количество чисел, среднее число - {ar[ar.Length/2]} остается без пары");
}
*/
int[] PairMult (int[]ar)
{
    //int mult=0;
    int[] mult = new int [ar.Length/2];
    int j = ar.Length-1;
    for (int i=0; i<ar.Length/2; i++)
    {
        mult[i] = ar[i]*ar[j];
        j--;
    }
    return mult;
    //if (ar.Length%2 != 0) Console.WriteLine ($"В массиве нечетное количество чисел, среднее число - {ar[ar.Length/2]} остается без пары");
}

int[] array = new int [9];
FillAndPrint(array);
Console.WriteLine();
Print(PairMult(array));
