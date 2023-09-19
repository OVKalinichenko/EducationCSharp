// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4

System.Console.WriteLine("Enter number N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= number)
{
   if(count % 2 == 0)
   {
      System.Console.Write ($"{count}, ");
      count++;  
   }
   else
   {
      count++;  
   }
   
}