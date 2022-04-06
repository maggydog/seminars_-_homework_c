// 23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i<=n ;i++)
{
   //Console.WriteLine($"{i}^2 = {i*i}");
   Console.Write($"{i} \t");
}
Console.WriteLine();
for (int j = 1;j<=n; j++)
{
   Console.Write($"{j*j} \t");
}
   