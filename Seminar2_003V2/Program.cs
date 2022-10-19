Console.Write("Ввидите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int digit1 = number % 10;
int digit2 = (number / 10) % 10;
int digit4 = (number / 1000) % 10;
int digit5 = (number / 10000) % 10;

if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine($"Число {number} является полиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является полиндромом");
}