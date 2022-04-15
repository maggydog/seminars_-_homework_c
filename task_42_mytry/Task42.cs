// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите несколько чисел через пробел");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); //С 8ого числа не работает
int count = 0;

for (int index=0; index < array.Length; index++)
{
    if (array[index] > 0) 
    {
        count ++;
    }
}
Console.WriteLine(count);