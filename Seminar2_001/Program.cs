// дано число. Проверить кратно они 7 и 23

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number % 6 == 0 && number % 12 == 0)
{
    Console.WriteLine($"Число {number} кратно 6 и 24");
}
else
{
    Console.WriteLine($"Число {number} не кратно 6 и 24");
}