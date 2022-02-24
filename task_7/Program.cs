// Показать числа от -N до N
int maxN = int.Parse(Console.ReadLine());
int minN = -maxN;
while (minN<=maxN)
{
    Console.WriteLine(minN);
    minN++;
}
