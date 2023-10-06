// ====== Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//         System.Console.Write($"{array[i]}\t");
//     }
// }

// int[] CreateSizedArray(int size)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write($"Enter number {i + 1}: ");
//         myArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return myArray;
// }
// int CountPositiveNumbersInArray(int[] array)
// {
//     int countNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             countNegative++;
//         }
//     }
//     return countNegative;
// }

// System.Console.Write("Enter array size (number of elemets): ");
// int sizeM = Convert.ToInt32(Console.ReadLine());

// int[] arrayM = CreateSizedArray(sizeM);
// System.Console.WriteLine();
// System.Console.WriteLine("Final array: ");
// PrintArray(arrayM);
// System.Console.WriteLine();
// System.Console.WriteLine();
// System.Console.WriteLine($"Number of positive elements: {CountPositiveNumbersInArray(arrayM)}");



// ====== Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x - k2*x = b2 - b1
// x = (b2 - b1)/(k1 - k2)
// y = k1 * x + b1

double[] CrossPoint(double k1, double k2, double b1, double b2)
{
    int size = 2;
    double[] cross = new double[size];
    cross[0] = (b2 - b1) / (k1 - k2);
    cross[1] = k1 * cross[0] + b1;
    return cross;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($"{array[i]}; ");
    }
}


System.Console.Write("Enter k1: ");
double numk1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter k2: ");
double numk2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter b1: ");
double numb1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter b2: ");
double numb2 = Convert.ToInt32(Console.ReadLine());

double[] point = CrossPoint(numk1, numk2, numb1, numb2);

System.Console.Write("(");
PrintArray(point);
System.Console.Write(")");