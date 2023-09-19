// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да

System.Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine($"Number {number} is even");
}
else
{
    Console.WriteLine($"Number {number} is odd");
}