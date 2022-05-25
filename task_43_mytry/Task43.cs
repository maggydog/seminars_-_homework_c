// 43. Написать программу преобразования десятичного числа в двоичное
int n = int.Parse(Console.ReadLine());
//string m = Convert.ToString (n,2);
//Console.WriteLine(m);
int[] array = new int[100];
int i = 0;
while (n>=2)
{ 
    array[i] = n%2;
    n=n/2;
    i++;
}
array[i] = n;

while (i>=0)
{
Console.Write (array [i]);
i--;
}


