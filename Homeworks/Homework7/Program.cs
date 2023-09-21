// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 1 -> нет

bool DayOfTheWeeK(int num)
{
    if(num < 6)
    {
        return false;
    }
    else
    {
        return true;
    }
}
Console.Write("Enter a week-day number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 7)
{
    System.Console.WriteLine("Wrong number. True again.");
}
else
{
    System.Console.WriteLine($"Is it a weekend -> {DayOfTheWeeK(number)}");
}