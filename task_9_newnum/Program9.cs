// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = new Random(). Next (10,99);
Console.WriteLine ("У нас есть число " + a);
int b = a%10;
int c = a/10;
if (b>c) Console.WriteLine(b);
else if (b<c)Console.WriteLine(c);
else Console.WriteLine ("Цифры числа равны");
