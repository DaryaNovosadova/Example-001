Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number < 100) || (number > 999))
{
    Console.WriteLine("Введите трехзначное число: ");
}
else
{
    int EndOfNumber = number%10;
    Console.Write(EndOfNumber);
}