// ==== Напишите программу, которая подсчитывает количество четных элементов в массиве 
// целых положительных трехзначных чисел и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, который принимает массив целых 
// положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
// который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.

// int CountEvenElements(int[] array)
// { 
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if(array[i]% 2 == 0);
//        {
//             count++;
//        }
//     }
//     return count;
// }
// void PrintArray(int[] array)
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//         System.Console.Write($"{array[i]}{(i<array.Length-1)?" \t ":" \t "}" );
//     } 
//     System.Console.WriteLine();
// }

// ==== Напишите программу, которая находит сумму элементов с нечетными индексами в 
// одномерном массиве целых чисел и выводит результат на экран.

// Программа должна иметь метод SumOddElements, который принимает массив 
// целых чисел и возвращает сумму элементов с нечетными индексами в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// int SumOddElements(int[] array)
//     {
//         int sunOdd = 0;
//         for (int i = 1; i < array.Length; i+=2)
//         {
//             sunOdd +=array[1];
//         }
//         return sunOdd;
//     }


// Напишите программу для работы с массивом вещественных чисел.

// Реализуйте класс ArrayOperations, который содержит следующие статические методы:

// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает
// максимальное число из массива.

// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает
// минимальное число из массива.

// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел
// array и возвращает разницу между максимальным и минимальным числами в массиве.

// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array
// и выводит его элементы с двумя знаками после запятой через табуляцию.

// double FindMin(double[] array)
//     {     
//         double min = array[0];
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (min > array[i]) 
//             {
//                 min = array[i];
//             }
//         }
//         return min;
//     }

// double FindMax(double[] array)
//     {     
//         double max = array [0];
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (max < array[i]) 
//             {
//                 max = array[i];
//             }
//         }
//         return max;
//     }
// double CalcDifferenceBetweenMaxMin(double[] array)
//     {
//         double maxDif = FindMax(array);
//         double minDif = FindMin(array);
//         double diff = maxDif - minDif;
//         return diff;
//     }