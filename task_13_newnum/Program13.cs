// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs (a);

int digit = 0;

while (a / 1000 > 0)
    {
        digit = a % 10;
        a = a / 10;
        digit = a % 10;
    }

if (a / 1000 == 0 && a / 100 > 0) Console.WriteLine("Теперь выведем третью цифру этого числа: " + a % 10);
    

else if (a / 100 == 0) Console.WriteLine("У этого числа нет третьей цифры");



/* int digit = 0;

while (a / 1000 > 0 || a / 1000 < 0)
    {
        digit = a % 10;
        a = a / 10;
        digit = a % 10;
    }

if (a / 1000 == 0 && (a / 100 > 0 || a / 100 < 0))
{
    if (a % 10 > 0) Console.WriteLine("Теперь выведем третью цифру этого числа: " + a % 10);
    else Console.WriteLine($"Теперь выведем третью цифру этого числа: {-1 * a % 10}");
}

else if (a / 100 == 0)
{
    Console.WriteLine("У этого числа нет третьей цифры");
}
*/

