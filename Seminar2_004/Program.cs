Console.Write("Enter your number ");
int number = int.Parse(Console.ReadLine() ?? "0");
int copy = number;
int revers = 0;
while(copy > 0)
{
    revers = revers * 10 + copy % 10;
    copy/= 10;
}
//if(number == revers)
//  Console.WriteLine("Polindrome");
//else
//  Console.WriteLine("Not polindrome");
//int a = 5;
//int b = 4;
//int max = a > b ? a : b;
Console.WriteLine(number == revers ? "Polindrome" : "Not polindrome");

