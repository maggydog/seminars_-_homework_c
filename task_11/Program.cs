int a = new Random(). Next (10,99);
Console.WriteLine ("У нас есть число " + a);

int num1 = a % 10;
int num2 = a / 10;

if (num1>num2) Console.WriteLine(num1);

else Console.WriteLine(num2);   

