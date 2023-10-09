// ===== Задайте двумерный массив размером m x n, заполненнный случайными целыми числами

// int InputInteger(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int minValue, int maxValue)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t"); ;
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = InputInteger("Enter number of rows: ");
// int column = InputInteger("Enter number of columns: ");
// int min = InputInteger("Enter min value: ");
// int max = InputInteger("Enter max value: ");
// int[,] array2D = Create2DArray(row, column);
// Fill2DArray(array2D, min, max);
// Print2DArray(array2D);


// ===== Задайте двумерный массив размером m x n, каждый элемент которого находится 
// по формуде a[m,n] = m + n.

// int InputInteger(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void FillArrayWithFormul(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t"); ;
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = InputInteger("Enter number of rows: ");
// int column = InputInteger("Enter number of columns: ");
// int[,] array2D = Create2DArray(row, column);
// FillArrayWithFormul(array2D);
// Print2DArray(array2D);


// ===== Задать двумерный массив, найти элементы, у которых оба индекса четные 
// и заменить элементы на их квадраты.

// int InputInteger(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int minValue, int maxValue)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t"); ;
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] *= array[i, j];
//             }
//         }
//         System.Console.WriteLine();
//     }
// }
// int row = InputInteger("Enter number of rows: ");
// int column = InputInteger("Enter number of columns: ");
// int min = InputInteger("Enter min value: ");
// int max = InputInteger("Enter max value: ");
// int[,] array2D = Create2DArray(row, column);
// Fill2DArray(array2D, min, max);
// Print2DArray(array2D);
// ChangeArray(array2D);
// System.Console.WriteLine("CHANGED ARRAY");
// Print2DArray(array2D);


// ===== Задать двумерный массив, найти сумму элементов, находящихся на главной диаганалию

int InputInteger(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t"); ;
        }
        System.Console.WriteLine();
    }
}

int SumArrayMainDiagamal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i, i];
    }
    return sum;
}
int row = InputInteger("Enter number of rows: ");
int column = InputInteger("Enter number of columns: ");
int min = InputInteger("Enter min value: ");
int max = InputInteger("Enter max value: ");
int[,] array2D = Create2DArray(row, column);
Fill2DArray(array2D, min, max);
Print2DArray(array2D);
System.Console.WriteLine($"Sum of the main diagamal's elements: {SumArrayMainDiagamal(array2D)}");

