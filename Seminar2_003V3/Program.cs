Console.Write("Enter your number");
int number = int.Parse(Console.ReadLine() ?? "0");
int copy = number;
int revers = 0;
while(copy > 0)
{
    int digit = copy %10;
    revers = revers * 10;
    revers = revers + digit;
    copy = copy / 10;
}
Console.WriteLine($"{number} {revers}");
Console.WriteLine(revers);
if(number == revers)
    Console.WriteLine("Polindrome");
else
    Console.WriteLine("Not polindrome");