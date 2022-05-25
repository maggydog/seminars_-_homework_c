// 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)


int n;
Console.WriteLine("Введите длину массива: ");
while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
{
    Console.WriteLine("Ошибка ввода, введите целое положительное число: ");
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i] }");
    }
}

void ChangeArray(int[] arr)
{
    int temp = 0;
    //int last = arr.Length - 1;
    /*   int index = 0;
    while (index<arr.Length/2)
    {
        temp = arr[index];
        arr[index] = arr[last];
        arr[last] = temp;
        index++;
        last--;
    }
*/
    for (int index = 0; index < arr.Length / 2; index++)
    {

        temp = arr[index];
        arr[index] = arr[arr.Length-1-index];
        arr[arr.Length-1-index] = temp;
        //last--;
    }


}


int[] ReverseArray (int[]arr)
{
    int[] reverse = new int [arr.Length];
    for (int i=0; i<arr.Length;i++)
    {
        reverse[i]=arr[arr.Length-1-i];
    }
    return reverse;
}

void ChangeArrays (int[] old, int[] now)
{
    for (int i=0; i<old.Length;i++)
    {
       old[i]=now[i];
    }
}

int[] array = new int[n];
FillArray(array);
PrintArray(array);
//ChangeArray(array);
int[] newarray = ReverseArray(array);
ChangeArrays(array, newarray);
Console.WriteLine();
PrintArray(array);