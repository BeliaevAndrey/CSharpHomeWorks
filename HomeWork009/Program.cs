using System;
using System.Threading;

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumOfNaturalsControl(int m, int n)
{
    int k = n;
    for(int i = m; i < k; i++)
    {
        Console.WriteLine(i + "\t" + m + "\t" + n);
        m += (n--) ;
    }
    return m;
}


int SumOfNaturals(int m, int n)
{
    int result = n;
    if(n != m)
    {
        Console.WriteLine(m + "\t" + n);
        return SumOfNaturals(m + n, n - 1);
    }
    return m;
}

// Console.WriteLine("Введите первое целое число M: ");
// int startNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число N: ");
// int finNum = Convert.ToInt32(Console.ReadLine());

var (startNum, finNum) = (1, 15);

Console.WriteLine();
Console.WriteLine($"{startNum}; {finNum} -> {SumOfNaturalsControl(startNum, finNum)}");


// (startNum, finNum) = (1, 15);

Console.WriteLine();
Console.WriteLine($"{startNum}; {finNum} -> {SumOfNaturals(startNum, finNum)}");



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

