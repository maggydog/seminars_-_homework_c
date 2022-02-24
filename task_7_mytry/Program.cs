// Показать числа от -N до N
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число n = "+ n + ", ниже вы увидите числа от -n до n");
int m = n;
Console.WriteLine(m);
int p = 0;
while (-n<m && m<=n)
{
    m=m-1;
    Console.WriteLine(m);
}
