// 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

while (day > 7 || day<=0)
{
    Console.WriteLine("Вам стоит придумать ему номер от 1 до 7, ведь в одной неделе всего 7 дней");
    day = int.Parse(Console.ReadLine());
}
if (day == 6 || day == 7) Console.WriteLine("Ура, сегодня выходной");
else Console.WriteLine("Сегодня будний день");

