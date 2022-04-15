// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse (Console.ReadLine());

if (a%b==0) Console.WriteLine ("Первое число кратно второму");
else  Console.WriteLine ($"Остаток от деления {a} на {b}: {a%b}");
 