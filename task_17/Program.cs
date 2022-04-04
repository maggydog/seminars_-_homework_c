// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine ("Введите первое число");
int num1 = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2 = int.Parse (Console.ReadLine());
if (num1 == num2*num2 || num2 == num1*num1) Console.WriteLine($"Одно число является квадратом другого");
else Console.WriteLine($"Ни одно из указанных Вами чисел не является квадратом другого");