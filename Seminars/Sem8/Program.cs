// ====== Задание 1 Задайте двумерный массив. Напишите программу, которая меняет 
// местами указанные строки массива.

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

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
    {
        System.Console.WriteLine("Wrong row's numbers");
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    }
}

System.Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter min values: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());


// ======= Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцаю. В случаи, если это не возможно, программа выдает сообщение 
// для пользователя. 

void RowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) System.Console.WriteLine("Wrong array");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
}


// ==== Задание 3. Из двумерного массива массива целых чисел удалить строки и столбцы, 
// на пересечении которых находится наименьший элемент (то есть заменить в строках и 
// столбцах элементы на "0")

void DeleteRowColonmMin(int[,] array)
{
    int min = array[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
                minJ = j;

            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, minJ] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[minI, j] = 0;
    }
}

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
System.Console.WriteLine();
ChangeRows(myArray, row1, row2);
Print2DArray(myArray);
System.Console.WriteLine();
RowsToColumns(myArray);
Print2DArray(myArray);
System.Console.WriteLine();
DeleteRowColonmMin(myArray);
Print2DArray(myArray);
