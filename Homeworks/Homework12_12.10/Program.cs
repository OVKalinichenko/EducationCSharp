// ====== Задание 1.PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход 
// двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку 
// матрицы так, чтобы элементы в каждой строке шли по убыванию.

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t"); ;
//         }
//         System.Console.WriteLine();
//     }
// }

// void SortRowsDescending(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int g = j+1; g < matrix.GetLength(1); g++) 
//             {    
//                 int max = matrix[i, j];
//                 if (max < matrix[i, g])
//                 {
//                     int temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, g];
//                     matrix[i, g] = temp;
//                 }
//             }
//         }
//     }
// }


// ===== Задание2. SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной 
// строке row матрицы matrix. Метод принимает двумерный массив целых чисел matrix и номер 
// строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
// номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.


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
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} "); ;
        }
        System.Console.WriteLine();
    }
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int[] result = new int[2];    
    int minSum = SumOfRow(matrix,0);
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        if (SumOfRow(matrix, i) < minSum)
        {
            minSum= SumOfRow(matrix,i);
            minIndex = i;
        }
    }
    result[0] = minIndex;
    result[1] = minSum;
    return result;
}

void PrintSimpleArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter min values: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"Sum of the first row: {SumOfRow(myArray, 0)}");
int[] minSumRow = MinimumSumRow(myArray);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

// ===== Задание3. MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно 
// ли умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA не равно 
// числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." 
// В противном случае, вызывается метод MatrixMultiplication для умножения матриц, 
// и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц 
// matrixA и matrixB. Метод возвращает новую матрицу, которая представляет собой результат 
// умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.
// void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
// {
//     if (matrixA.GetLength(1) != matrixB.GetLength(0)) System.Console.WriteLine("It is impossible to multiply.");
//     else PrintMatrix(MatrixMultiplication(matrixA, matrixB));
// }

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] matrixMultiple = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int f = 0; f < matrixB.GetLength(1); f++)
//         {
//             matrixMultiple[i, f] = 0;
//             for (int j = 0; j < matrixA.GetLength(1) && j < matrixB.GetLength(0); j++)
//             {
//                 matrixMultiple[i, f] += matrixA[i, j] * matrixB[j, f];
//             }
//         }
//     }
//     return matrixMultiple;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t"); ;
//         }
//         System.Console.WriteLine();
//     }
// }

