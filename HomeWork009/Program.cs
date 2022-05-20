using System;
using System.Threading;

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*

int SumOfNaturals(int m, int n, int steps = 0)
{
    if(steps == 0 && m - n < 0)
        steps = n - m;
    
    if(steps != 0)
        return SumOfNaturals(m + n, n - 1, --steps);
   
    return m;
}

int startNum = 0, finNum = 0;
while(true)
{
    Console.WriteLine("Введите первое целое число M: ");
    startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое число N > M: ");
    finNum = Convert.ToInt32(Console.ReadLine());

    if(finNum > startNum)
        break;
    else
        Console.WriteLine("Ошибка ввода: второе число должно быть больше первого. Пожалуйста, повторите попытку.");
}

Console.WriteLine();
Console.WriteLine($"{startNum}; {finNum} -> {SumOfNaturals(startNum, finNum)}");

*/


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

/*

int SumOfDigits(int n, int result)
{
    if(n / 10 == 0)
        return result;
    else
        return SumOfDigits(n /= 10, result += n % 10);
}


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Сумма: " + number + " -> " + SumOfDigits(number, number % 10));

*/

