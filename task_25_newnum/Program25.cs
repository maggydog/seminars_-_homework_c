//25. Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B. 

Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Укажите степень, в которую Вы хотите возвести число: ");
int b;
while (!int.TryParse (Console.ReadLine(), out b) || b<0)
{
    Console.WriteLine ("Ошибка ввода. Число должно быть целым и положительным (если очень хочется, можно 0).");
    Console.WriteLine("Укажите степень, в которую Вы хотите возвести число: ");
}

void Pow (int m,int n)
{
    int pow = 1;
    for (int i=0;i<n;i++)
    {
        pow=pow*m;
    }
Console.WriteLine($"Результат: {pow}");
}

Pow(a,b);