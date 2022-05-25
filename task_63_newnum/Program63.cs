// 63. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/*int n=5;

for (int i=1; i<=n; i++)
Console.WriteLine(i);
*/

int m=7;

/*int FromOneToN (int n)
{
if (n==1)return 1;
else return FromOneToN(n-1);
}

Console.WriteLine(FromOneToN(m));*/

void FromOneToN (int a)
{
    if (a==1) Console.Write(a + " ");
    else 
    {
        FromOneToN(a-1);
        Console.Write(a+ " ");
    }
}

FromOneToN(m);