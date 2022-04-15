int a = new Random(). Next (10,99);
Console.WriteLine ("У нас есть число " + a);
int b = a%10;
int c = a/10;
if (b>c) Console.WriteLine(b);
if (b<c)Console.WriteLine(c);
else Console.WriteLine ("Цифры числа равны");