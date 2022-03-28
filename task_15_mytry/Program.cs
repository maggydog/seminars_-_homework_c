// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine ("Введите число: ");
int a =int.Parse(Console.ReadLine());
Console.WriteLine ("Проверим, делится ли число "+ a +" на 7 и на 23");

if (a%7 == 0 & a%23 == 0) Console.WriteLine ("Да");

else Console.WriteLine ("Нет");