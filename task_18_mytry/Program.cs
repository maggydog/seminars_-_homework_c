// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

/*bool x = true;
bool y = true;

if (!(x&&y) == !x || !y) Console.WriteLine ("Утверждение истинно при истинных x и y");
else Console.WriteLine ("Утверждение ложно при истинных x и y");

x = true;
y = false;

if (!(x&&y) == !x || !y) Console.WriteLine ("Утверждение истинно при истинном x и ложном y");
else Console.WriteLine ("Утверждение ложно при истинном x и ложном y");

x = false;
y = true;

if (!(x&&y) == !x || !y) Console.WriteLine ("Утверждение истинно при ложном x и истинном y");
else Console.WriteLine ("Утверждение ложно при ложном x и истинном y");

x = false;
y = false;

if (!(x&&y) == !x || !y) Console.WriteLine ("Утверждение истинно при ложных x и y");
else Console.WriteLine ("Утверждение ложно при ложных x и y");*/


Console.WriteLine ("Если первая переменная истинна - введите true, если ложна - false");
bool x = bool.Parse (Console.ReadLine());
Console.WriteLine ("Если вторая переменная истинна - введите true, если ложна - false");
bool y = bool.Parse (Console.ReadLine());

void Maybe (bool a, bool b)
{ 
    if (!(a&&b) == !a || !b) Console.WriteLine($"Выражение истинно");
    else Console.WriteLine($"Выражение ложно");
}
Maybe (x,y);