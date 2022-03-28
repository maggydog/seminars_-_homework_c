// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
int day = new Random().Next(1,7);
Console.WriteLine($"{day} день недели");
if (day == 6 | day == 7) Console.WriteLine ("Ура, сегодня выходной");
if (day != 6 & day != 7) Console.WriteLine ("Сегодня будний день");
if (day>7)Console.WriteLine("Вам стоит придумать ему номер от 1 до 7, ведь в одной неделе всего 7 дней");
