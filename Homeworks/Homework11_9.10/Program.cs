// ===== Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
// удовлетворяющую этим условиям.

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int value = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = value;
            value += 2;
        }
        value = 1 + 2 * m * (i + 1);
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t"); ;
        }
        System.Console.WriteLine();
    }
}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int[] result = new int[2];
    if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
    {
        result[0] = 0;
        result[1] = 0;
    }
    else
    {
        result[0] = matrix[rowPosition - 1, columnPosition - 1];
        result[1] = 0;
    }
    return result;
}

void PrintSimpleArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

void PrintCheckIfError(int[] results, int X, int Y)
{
    if (results[0] == 0) System.Console.WriteLine("There is no such index");
    else System.Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }

void PrintListAvr (double [] list)
{
    System.Console.WriteLine($"The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        
        System.Console.Write($"{list[i]:f2}\t ");
    }
}

double [] FindAverageInColumns (int [,] matrix)
    { 
    double[] list = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int averageColumn = 0;
        int sumColumn = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumn += matrix[i,j]; 
        }
        averageColumn = sumColumn / matrix.GetLength(0);
        list[j] = averageColumn;
    }
    return list;
    }

int[,] matr = CreateIncreasingMatrix(3, 4, 2);
PrintArray(matr);

System.Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

PrintSimpleArray(FindNumberByPosition(matr, rows, columns));
PrintCheckIfError(FindNumberByPosition(matr, rows, columns), rows, columns);
PrintListAvr(FindAverageInColumns(matr));