// ==== Задать массив из 12 элемментов, заполненный случайными числами из диапазона [ -9,9]. 
// Найти сумму отрицательных и положительных элементов массива.


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
// void PosNegSum(int[] array)
// {
//     int positiveSum = 0;
//     int negativeSum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             positiveSum += array[i];
//         }
//         else
//         {
//             negativeSum += array[i];
//         }
//     }
//     System.Console.WriteLine($" Sum of positive array elements ->{positiveSum}\n Sum of negative array elements ->{negativeSum}");
// }

// System.Console.WriteLine("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// System.Console.WriteLine();
// PosNegSum(myArray);


// ==== Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов масива лежащих в отрезке [10,99]

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
// int ElementsCounter(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= min && array[i] <= max)
//         {
//         count++;
//         }
//     }
//     return count;
// }

// System.Console.WriteLine("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter lower bound: ");
// int low = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter upper bound: ");
// int up = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine();
// System.Console.WriteLine(ElementsCounter(myArray, low, up));


// ==== Задайте массив. напишите программу, котороая определяет присутствует 
// ли заданное чмсло в массиве.

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

// bool FindElement(int[] array, int findNum)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == findNum) return true;   
//     }
//     return false;
// }

// System.Console.WriteLine("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine(FindElement(myArray, num));

// ==== Задайте массив. Напишите программу замены элементов масива: положительные элементы 
// заментить на соответствующие отрицательные и наообот.

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

// int[] ChangeSing(int[] array)
// {
//     for (int j = 0; j < array.Length; j++)
//     {
//         array[j] *= -1;
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
// System.Console.Write("Given array -> ");
// PrintArray(myArray);
// System.Console.WriteLine();

// int[] changedArray = ChangeSing(myArray);
// System.Console.Write("Changed array -> ");
// PrintArray(changedArray);