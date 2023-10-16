// ====== Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumsReverse(int n)
// {
//     if (n > 0)
//     {
//          System.Console.Write(n + " ");
//          ShowNumsReverse(n - 1);
//     }
// }
// ShowNumsReverse(10);


// ====== Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindIntervalSum(int m, int n)
// {
//     if (m != n)
//     {
//         if (m > n)
//         {
//             return FindIntervalSum(m - 1, n) + m;
//         }
//         else
//         {
//             return FindIntervalSum(m, n - 1) + n;
//         }
//     }
//     else return n;
// }

// System.Console.WriteLine(FindIntervalSum(8, 4));

// ====== Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction( int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

System.Console.WriteLine(AkkermanFunction(3,2));