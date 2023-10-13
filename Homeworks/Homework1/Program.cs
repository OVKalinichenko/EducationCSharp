// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7

System.Console.WriteLine("Enter number a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
   System.Console.Write ($"a = {numberA} is max");
}
else
{
   System.Console.Write ($"b = {numberB} is max"); 
}
