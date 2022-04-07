// 35. Определить, присутствует ли в заданном массиве, некоторое число 

void FillAndPrint(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        arr [i] = new Random().Next(-5,5);
        Console.Write ($"{arr[i]}\t");
    }
}

void FindSame (int[]ar, int a)
{
    for (int i=0; i<ar.Length; i++)
    {
        if (ar[i]==a) Console.WriteLine($"В массиве есть элемент с индексом {i} равный {a}");
    }
}

int[] array = new int [5];
Console.WriteLine("Введите число, которое будем искать в массиве: ");
int n = int.Parse(Console.ReadLine());
FillAndPrint(array);
Console.WriteLine();
FindSame(array,n);



