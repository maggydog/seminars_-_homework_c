//Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
Console.WriteLine(a+" "+" "+b);
if (a<b)Console.WriteLine ("Первое число меньше второго, остаток не посчитать");
else if (a%b == 0) Console.WriteLine ("Число кратно " + b);
else Console.WriteLine ("Остаток от деления: " + a%b);