//Программа проверяет пятизначное число на полиндром
Console.Write("Ввидите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[5];  //создаем массив
int index = 4;              //исследуем элементы массива с конца
while(index >= 0)
{
    array[index] = number%10;  //получаем последнюю цифру в массиве
    number = number/10;        //переходим к следующиму числу
    index--;                   //переходим к следующиму элементу массива
}
if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}