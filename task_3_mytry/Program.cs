// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели, название которого хотите узнать: ");
//Можно string a = Console.ReadLine(); тогда if выглядит так: if (a=="1")
//if...if else...if else...else  - тогда не сравнивается 7 раз
int today = int.Parse (Console.ReadLine());
Console.Write("Сегодня " + today + " по счету день недели,");
while (today==0 || today>7)
{
    Console.WriteLine("но вам стоит придумать ему номер от 1 до 7, ведь в неделе всего 7 дней");
    today = int.Parse (Console.ReadLine());
    Console.Write("Сегодня " + today + " по счету день недели,");
}

if (today==1)Console.WriteLine("и это понедельник");
else if (today==2)Console.WriteLine("и это вторник");
else if (today==3)Console.WriteLine("и это среда");
else if (today==4)Console.WriteLine("и это четверг");
else if  (today==5)Console.WriteLine("и это пятница");
else if  (today==6)Console.WriteLine("и это суббота");
else if  (today==7)Console.WriteLine("и это воскресенье");