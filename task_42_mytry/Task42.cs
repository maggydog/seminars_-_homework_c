// 42. Определить сколько чисел больше 0 введено с клавиатуры

/*Console.WriteLine("Введите несколько чисел через пробел");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); //С 8ого числа не работает
int count = 0;

for (int index=0; index < array.Length; index++)
{
    if (array[index] > 0) 
    {
        count ++;
    }
}
Console.WriteLine(count);*/

Console.WriteLine("Введите несколько чисел через enter, когда закончите - нажмите 0");
int count =0;
int a=1;
while (a != 0)
{
    a = int.Parse(Console.ReadLine());
    if (a>0) count++;
}

Console.WriteLine($"Всего положительных чисел: {count}");

/*int[] array = new int[10];
int i=0;
for (i=0; i<array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int count = 0;
if (array[i]>0) count ++;
Console.WriteLine(count);*/
