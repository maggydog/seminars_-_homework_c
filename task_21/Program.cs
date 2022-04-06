// // 21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
//Добавлю проверку на пятизначность
while (a<10000 || a>99999)
{
    Console.WriteLine ($"Число {a} - не является пятизначным, введите пятизначное число");
    a = int.Parse(Console.ReadLine());
}

if (a/10000==a%10 && a/1000%10==a%100/10) Console.WriteLine ($"Число {a} - полиндром");
else Console.WriteLine ($"Число {a} - не является полиндромом");
    

