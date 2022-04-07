// 27. Определить количество цифр в числе
/*
Через строку
Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
Console.WriteLine($"Количество цифр в числе {a}:  {a.Length}");*/

// Арифметика
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());

void Num (int n)
{
    int count = 0;
    while (n>0)
    {
       n = n/10;
       count++;

    }
Console.WriteLine ($"Количество цифр в числе: {count}");   
}
Num(b);

