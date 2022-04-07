// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
int [] array = new int[8];

void FillArray (int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index<length)
    {
        arr[index]=new Random(). Next (0,2);
        index++;
    }
}

void PrintArray (int[] ar)
{
    int l = ar.Length;
    int position = 0;
    while (position<l)
    {
        Console.WriteLine(ar[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);

