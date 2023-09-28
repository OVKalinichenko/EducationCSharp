// ==== Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3

// int DigitCount(int num)
// {
//     int count = 0;
//     for (int i = 1; Math.Abs(num) > 0; i++)
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }
// System.Console.WriteLine("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(number));


// ==== Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами
// в случайном порядке
//[1, 0, 1, 1, 0, 0, 1, 1,] 

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.WriteLine("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, min, max));


// ==== Написать программу, которая принимает на вход число(А) и выдает сумму чисел от 1 до А

// int GetSum (int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// System.Console.WriteLine("Enter number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetSum(numA));

// ==== Написать программу, которая принимает на вход число (N) и выдает произведение 
// чисел от 1 до N (факториал)

// int GetFactorial(int num)
// {
//     int fact = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         fact = fact * i;
//     }
//     return fact;
// }

// System.Console.WriteLine("Enter number N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetFactorial(numN));