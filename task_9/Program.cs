//Показать последнюю цифру трёхзначного числа

//Console.WriteLine("Введите число: ");
//string num = Console.ReadLine();
//int y = num[num.Length-1]-'0';
//Console.WriteLine("Последняя цифра числа: " + y);

int Last (int b)
{
    //int num = b%10;
    //return num;
    return b%10;
}
Console.WriteLine("Введите число - ");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра: " + Last(a));