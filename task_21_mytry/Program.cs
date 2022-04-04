// 21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите число");
string a = Console.ReadLine();
int l = a.Length-1;
int count = a.Length/2;
int i = 0;
while (i<count)
{
    if (a[i]==a[l])
    { 
        i++;
        l--;
        {
            if (i>=count) Console.WriteLine("Число является полиндромом");
        }
    } 
  
    else 
    {
        Console.WriteLine ("Число не является полиндромом");
        break;
    }    
} 

