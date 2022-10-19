int ReverseNumber(int number)
{
    int reverse = 0;
    while(number > 0)
    {
        reverse = reverse * 10 + number % 10;
        number /= 10;
    }
    return reverse;
}
bool IsPolindrome(int number) => number == ReverseNumber(number);
int number = 0;
Console.Write("Enter a number: ");
while(!int.TryParse(Console.ReadLine() ?? "0", out number))
{
    Console.WriteLine("This string is not a number");
    Console.Write("Enter your number: ");
}
Console.WriteLine(IsPolindrome(number) ? "Polindrome" : "Not polindrome");
