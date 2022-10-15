Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите квадрат числа: ");
int kv = int.Parse(Console.ReadLine());
int sqr = number * number;

if(sqr == kv)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
    Console.WriteLine(sqr);
}