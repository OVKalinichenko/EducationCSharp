// ===== Задание 1. Задайте значение N. Напищите программу, которая выведет все натуральные числа в 
// промежутке от 1 до N

// void ShowNums(int n)
// {
//     if (n > 0) // Условие выхода
//     {
//         ShowNums(n - 1); // Вызов рекурсии со следующим аргументом
//         System.Console.Write(n + " ");
//     }
// }
// ShowNums(10);


// ===== Задание2. Напишите программу, которая на вход принимала число и возвращает 
// сумму всех цифр числа

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else return num;
// }
// System.Console.WriteLine(FindSum(453));

// Задание 3. Задайте значение M и N. Напишите программу, котороая выведет все натуральные 
// числа в промежутке от n до m

void FindDeaposon(int m, int n)
{
    if (m != n)
    {
        if (m > n)
        {
            FindDeaposon(m - 1, n);
        }
        else
        {
            FindDeaposon(m, n - 1);
        }
    }
    System.Console.Write(m + " ");
}

FindDeaposon(8, 5);

// ===== Задание 4. Напишите программу, которая на вход принимает два числа 
// А и В и возводит число А в степень В.

// int FindPowerOfNumber(int a, int b)
// {
//     if (b > 0)
//     {
//         return FindPowerOfNumber(a, b - 1) * a;
//     }
//     else return 1;
// }

// System.Console.WriteLine(FindPowerOfNumber(5, 5));

// !!!!!! Рекурсия идет туда и обратно возвращает результат. Все идет по этапно.