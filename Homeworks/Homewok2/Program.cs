// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

System.Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter third number: ");
int number3= Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 > max ) max = number1;
if (number2 > max ) max = number2;
if (number3 > max ) max = number3;

Console.Write("max = ");
Console.WriteLine(max);