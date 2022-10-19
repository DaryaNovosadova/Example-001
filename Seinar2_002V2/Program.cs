Console.WriteLine("Определения четверти плоскости");

Console.Write("Ввидите координату x: ");
int X = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ввидите координату y: ");
int Y = int.Parse(Console.ReadLine() ?? "0");

if(X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}