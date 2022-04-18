// 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

//Для пятизначного числа
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine());
void CheckPalindrome(int a)
{
    if (a < 0) a = -a;

    while (a < 10000 || a > 99999)
    {
        Console.WriteLine($"Число {a} - не является пятизначным, введите пятизначное число");
        a = int.Parse(Console.ReadLine());
        if (a < 0) a = -a;
    }

    if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10) Console.WriteLine($"Число {a} - палиндром");
    else Console.WriteLine($"Число {a} - не является палиндромом");
}

CheckPalindrome(n);


//Для любого числа
Console.WriteLine("Теперь проверим любое число: ");
int m = int.Parse(Console.ReadLine());
if (m < 0) m = -m;


string k = m.ToString();

void CheckPalindromeAll(string b)
{
    int l = b.Length - 1;
    int count = b.Length / 2;
    int i = 0;

    if (b.Length == 1)
    {
        Console.WriteLine("Число является палиндромом");
    }
    while (i < count)
    {
        if (b[i] == b[l])
        {
            i++;
            l--;
            {
                if (i >= count) Console.WriteLine("Число является палиндромом");
            }
        }

        else
        {
            Console.WriteLine("Число не является палиндромом");
            break;
        }
    }
}

CheckPalindromeAll(k);