// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine ("Введите первое число");
int num1 = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2 = int.Parse (Console.ReadLine());
void Sqare (int a, int b)
{ 
    if (a == b*b) Console.WriteLine($"Первое число - {a} является квадратом второго числа - {b}");
    else if (b == a*a) Console.WriteLine($"Второе число - {b} является квадратом первого числа - {a}");
    else Console.WriteLine($"Ни одно из указанных Вами чисел не является квадратом другого");
}
Sqare(num1,num2);

/*if (num1 == num2*num2) Console.WriteLine($"Первое число - {num1} является квадратом второго числа - {num2}");
else if (num2 == num1*num1) Console.WriteLine($"Второе число - {num2} является квадратом первого числа - {num1}");
else Console.WriteLine($"Ни одно из указанных Вами чисел не является квадратом другого");*/