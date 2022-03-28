// Показать четные числа от 1 до N
int N = int.Parse(Console.ReadLine());
int m = 1;
while (1<=m & m<=N)
{
    if(m%2==0)
    {
        Console.WriteLine(m);
    }
    m++;
}

