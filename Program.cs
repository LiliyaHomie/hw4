// // // Напишите цикл, который принимает на вход два числа (A и B) и 
// // возводит число A в натуральную степень B.
// // // 3, 5 -> 243 (3⁵)
// // // 2, 4 -> 16

// bool ValidNum (int num2)
// {
//     if (num2 <= 0)
//     {
//         System.Console.WriteLine("Число не должно быть меньше нуля");
//         return false;
//     }
//     return false;
// }

// int Degree (int num1, int num2)
// {
//     int degree = 1;
//     for (int i = 0; i < num2; i++)
//     {
//         degree *= num1;
//     }
//     return degree;
// }

// int num1 = PrintNum ("Введите число: ");
// int num2 = PrintNum ("Введите число: ");
// if (ValidNum(num2))
// {
//     System.Console.WriteLine($"Число {num1} в степени числа {num2} равно {Degree(num1, num2)}");
// }

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
// в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumAllDigit (int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num = num / 10; 
    }
    return result;
}

int num = PrintNum("Enter number: ");
Console.WriteLine($"Sum of all digits in num {num} = {SumAllDigit(num)}");
// +++++ Metods +++++

 int PrintNum (string Message)
 {
    System.Console.Write(Message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
 }
 