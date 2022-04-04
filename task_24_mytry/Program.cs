// 24. Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i<=n ;i++)
{
   Console.WriteLine($"{i}^3 = {i*i*i}");
}
