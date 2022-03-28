// 14. Найти третью цифру числа или сообщить, что её нет
Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели число: "+a);
int digit = 0;

if (a/100 == 0)
{
Console.WriteLine("У этого числа нет третьей цифры");
}

else if (a/1000>0)
{  
     while (a/1000>0)
    {
        digit=a%10;
        a=a/10;
        digit=a%10;
    }
Console.WriteLine ($"Теперь выведем третью цифру этого числа: {digit}");
}


else if ( a/1000==0 & a/100 > 0)
{
Console.WriteLine("Теперь выведем третью цифру этого числа: "+ a%10);

}





