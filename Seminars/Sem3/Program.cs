// Написать програму которая принимает на вход координаты точки (при x и y не равных нулю)
// и выдает номер четверти координатной плоскости, в которой находится эта точка.

// int FindQuarter(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x > 0 && y < 0) return 4;
//     if(x < 0 && y < 0) return 3;
//     if(x < 0 && y > 0) return 2;
//     else return 0;
// }

// System.Console.Write("Enter coordinate x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter coordinate y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindQuarter(x, y));


// //Напишите программу, которая принимает на вход число N и выдает таблицу 
// квадратов числа от 1 до N
// 5 ->1, 4, 9, 16, 25 

// void QuadTable(int n)
// {
//     int current = 1;
//     while(current <= n)
//         {
//             System.Console.Write(current * current + ", ");
//             current++;
//         }
// }
// System.Console.Write("Input N:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($" -> ");
// QuadTable(n);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (х и у).

// void CoordQuarter(int quar)
// {
//     if(quar == 1)
//     {
//         System.Console.WriteLine("x > 0 and y > 0 ");
//     }
//     else if( quar == 2)
//     {
//         System.Console.WriteLine("x < 0 and y > 0 ");
//     }
//     else if( quar == 3)
//     {
//         System.Console.WriteLine("x < 0 and y < 0 ");
//     }
//     else if( quar == 4)
//     {
//         System.Console.WriteLine("x > 0 and y < 0 ");
//     }
//     else 
//     {
//         System.Console.WriteLine("Wrong quarter!");
//     }
// }
// System.Console.Write("Enter quarter number (from 1 to 4): ");
// int q = Convert.ToInt32(Console.ReadLine());
// CoordQuarter(q);


// Написать программу которая принимает на вход координаты двух точек и находит 
// расстояние между ними


// double Distance( double xa, double ya, double xb, double yb)
// {
//     return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
// }

// System.Console.Write(" Enter coordinate x of A: ");
// double xa = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate y of A: ");
// double ya = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate x of B: ");
// double xb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(" Enter coordinate y of B: ");
// double yb = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Расстояние между точками А ({xa}, {ya}) и В ({xb}, {yb}) -> {Math.Round(Distance(xa, ya, xb, yb))}");