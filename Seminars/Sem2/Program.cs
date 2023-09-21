// // Напишите программу, которая будет принимать на вход два числаи, а выдовать, является ли второе число
// // кратным первому. если второе число не кратно, то выводится остаток от деления.

// void CheckMultiplicity(int number1, int number2)
// {
//     if(number1 % number2 == 0)
//     {
//         System.Console.WriteLine($" {number1}, {number2} -> кратно");
//     }
//     else
//     {
//         System.Console.WriteLine($" {number1}, {number2} -> не кратно; остаток { number1 % number2}");
//     }
// }

// System.Console.WriteLine("Enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// CheckMultiplicity(number1, number2);


// Напишите программу, которая выводит случайное чмсло из [10, 99] и показывает наибольшую цифру числа

// int BiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed > dec)
//     {
//         return ed;
//     }
//     else 
//     {
//         return dec;
//     }
// }

// int num = new Random().Next(10,100);

// Console.WriteLine(num);
// // int result = BiggestDigit(num)
// Console.WriteLine(BiggestDigit(num));


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 > 46

// void TreeToTwoDigit(int num)
// {
//   int ed = num % 10;
//   int hun = num / 100;
//   Console.WriteLine($" {num} -> {hun*10+ed}");
// }

// int num = new Random().Next(10,1000);
// TreeToTwoDigit(num);


//Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

// 17 -> нет
// 161 -> да

bool MultipleCheck(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Enter a digit: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MultipleCheck(number));
