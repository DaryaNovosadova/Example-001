//Определить номер четверти плоскости, в которой находятся точка с координатами x и y, причем X не равна 0 и y тоже

Console.Write("Ввидите x: ");
int X = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ввидите y: ");
int Y = int.Parse(Console.ReadLine() ?? "0");
if(X > 0)

    if(Y > 0)

    Console.WriteLine("Первая четверть");

    else

    Console.WriteLine("Четвертая четверть");
else
    if(Y > 0)

    Console.WriteLine("Вторая четверть");

    else

    Console.WriteLine("Третья четверть");