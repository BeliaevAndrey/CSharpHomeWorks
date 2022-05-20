// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;

int SumOfNaturals(int m, int n)
{
    if(n != m)
    {
        Console.WriteLine(m + "\t" + n);
        // m += n;
        return SumOfNaturals(m + n, 1);
    }
    return m;
}

Console.WriteLine("Введите первое целое число M: ");
int startNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число N: ");
int finNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"{startNum}; {finNum} ->  {SumOfNaturals(startNum, finNum)}");




// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



