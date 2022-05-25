// 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//вариант 1

Console.WriteLine("Введите несколько чисел через enter, когда закончите - нажмите 0");
int count =0;
int a=1;
while (a != 0)
{
    while (!int.TryParse(Console.ReadLine(), out a)) Console.WriteLine("Ошибка ввода. Введите число:");
    if (a>0) count++;
}

Console.WriteLine($"Всего положительных чисел: {count}");

//вариант 2

Console.WriteLine("Сколько чисел вы хотите ввести?");
int n = int.Parse(Console.ReadLine());
int[] array2 = new int[n];
int count2 = 0;
for (int i=0; i<array2.Length; i++)
{
    array2[i] = int.Parse(Console.ReadLine());
    if (array2[i]>0) count2 ++;
}

Console.WriteLine($"Всего положительных чисел: {count2}");

// вариант 3
//??В этом случае, если числа длинные, с 8ого числа не работает

Console.WriteLine("Введите несколько чисел через пробел");
int[] array3 = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
int count3 = 0;

for (int index=0; index < array3.Length; index++)
{
    if (array3[index] > 0) 
    {
        count3 ++;
    }
}
Console.WriteLine($"Всего положительных чисел: {count3}");



