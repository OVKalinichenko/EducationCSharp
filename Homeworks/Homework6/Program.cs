// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdDigit(int num)
{
    int comp = 1000;
    int count = 1;
    if(num < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while(comp < 1000000000)
        {
            if(num < comp)
            {
                System.Console.WriteLine((num / count) % 10);
                break;
            }
            else{
                comp = comp * 10;
                count = count * 10;
            }
        }
        while(num >= 1000000000)
        {
            System.Console.WriteLine((num / 10000000) % 10);
            break;
        }
    }
}

Console.Write("Enter a digit: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigit(number);