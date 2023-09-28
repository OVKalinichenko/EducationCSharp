// ==== Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PowerOfNumber(int numA, int numB)
// {
//     int powerA = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         powerA *= numA;
//     }
//     return powerA;
// }

// System.Console.WriteLine("Enter number A: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter power of A: ");
// int power = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(PowerOfNumber(number, power));

// ==== Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// **** мой вариант

// int DigitSum(int num)
// {
//     int un = num % 10;
//     int ten = (num % 100 - un)/10;
//     int sum = un + ten;
//     int i = 1000;
//     int j = 100;
    
//     while (num > j)
//     {
//         int nextDigit = (num % i - num % j)/j;
//         sum += nextDigit;
//         i = i * 10;
//         j = j * 10;
//     }
//     return sum;
// }

// **** красивый вариант
int DigitSum(int num)
{
    int sum =0;
    while (num >0)
    {
        sum += num %10;
        num /=10;
    }
    return sum;
}

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(DigitSum(number));


// ==== Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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
//         System.Console.Write($"{array[i]}, ");
//     }
// }

// System.Console.WriteLine("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("[");
// PrintArray(CreateRandomArray(size, min, max));
// System.Console.Write("]");