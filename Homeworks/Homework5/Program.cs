// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5

void TensDigit(int num)
{
  int un = num % 10;
  int ten = (num - un) % 100;
  Console.WriteLine(ten / 10);
}

Console.Write("Enter tree-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
TensDigit(number);