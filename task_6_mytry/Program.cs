// Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число: "+a);
if (a%2==0)
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}
