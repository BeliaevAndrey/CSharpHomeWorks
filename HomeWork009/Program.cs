using System;
using System.Threading;

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Вариант 1.
int SumOfNaturals(int m, int n, int steps = 0)
{
    if(steps == 0 && m - n < 0)
        steps = n - m;
    
    if(steps != 0)
        return SumOfNaturals(m + n, n - 1, --steps);
   
    return m;
}

// Вариант 2.
int SumOfNaturals2(int m, int n)
{
    if(m <= n)
    {
        return m + SumOfNaturals(m + 1, n);
    }    
    return 0;
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


Console.WriteLine("Вариант 1.");
DateTime dt1 = DateTime.Now.ToLocalTime();
Console.WriteLine($"{startNum}; {finNum} -> {SumOfNaturals(startNum, finNum)}");
double resTime1 = (DateTime.Now.ToLocalTime() - dt1).TotalMilliseconds;

Console.WriteLine("Вариант 2.");
DateTime dt2 = DateTime.Now;
Console.WriteLine($"{startNum}; {finNum} -> {SumOfNaturals2(startNum, finNum)}");
double resTime2 = (DateTime.Now - dt2).TotalMilliseconds;


Console.WriteLine($"Время выполнения. Вариант 1: {resTime1} Вариант 2: {resTime2}");


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

