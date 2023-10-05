// ===== Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int[] ReverseArray(int[] array)
// {
//     int temp;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// System.Console.WriteLine("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine();
// myArray= ReverseArray(myArray);
// PrintArray(myArray);


// ======= Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10


// string DecimalToBimary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 +result;
//         num/=2;
//     }
//     return result;
// }

// System.Console.WriteLine("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine((DecimalToBimary(num)));


// ====== Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && c + b > a)
//     {
//         System.Console.WriteLine("Such triangle can exist.");
//         return true;
//     }
//     else 
//     {
//         System.Console.WriteLine("Such triangle doesn't exist.");
//         return false;
//     }
// }


// System.Console.WriteLine("Enter number a: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter number b: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter number c: ");
// int numC = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CheckTriangle(numA, numB, numC));


// ======= Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// int [] FibonacciN(int n)
// {
//     int[] array = new int[n];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.WriteLine("Enter number c: ");
// int num = Convert.ToInt32(Console.ReadLine());

// PrintArray(FibonacciN(num));