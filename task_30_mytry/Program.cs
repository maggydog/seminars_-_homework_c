// 30. Показать кубы чисел, заканчивающихся на четную цифру

int cube = 0;
int n = 1;  
while (n<100)
{
    if(n%2==0)
    {
        cube=n*n*n;
        Console.WriteLine ($"{n} ^ 3 = {cube}");
    }    
    n++;
}
