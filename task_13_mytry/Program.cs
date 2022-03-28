//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine ("Введите первое число, его мы попробуем разделить: ");
int a =int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число, на него мы будем делить: ");
int b =int.Parse(Console.ReadLine());
double c = a%b;
if (c==0) Console.WriteLine("Первое число без остатка делится на второе");
else Console.WriteLine ("Остаток от деления первого числа на второе: " + c);