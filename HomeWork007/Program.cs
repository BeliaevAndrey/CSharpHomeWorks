// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5     7    -2     -0,2
// 1      -3,3   8     -9,9
// 8       7,8  -7,1    9

using System;   // VS Code почему-то отказался подсвечивать код без этой инструкции

/*
double[,] CreateArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i, j] = Math.Round(min + (max - min) * new Random().NextDouble(), 2);    // Подсмотрено в задачнике Подбельского.

    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите нижнюю границу диапазона значений: ");
int down = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу диапазона значений: ");
int up = Convert.ToInt32(Console.ReadLine()) + 1;

Console.WriteLine("Результирующий массив:");
PrintArray(CreateArray(3, 4, down, up));
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintElement(int[,] array, int m, int n)
{
    if(m <= array.GetLength(0) && n <= array.GetLength(1))
    {
        Console.WriteLine($"Элемент на позиции: ({m}, {n}) -> {array[m-1, n-1]}");
    }
    else
        Console.WriteLine("Элемента с такими координатами нет.");
}

int rows = 0, cols = 0, posI = 0, posJ = 0;

while(true) 
{
    Console.Write("Введите количество строк (начиная с 1): ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов (начиная с 1): ");
    cols = Convert.ToInt32(Console.ReadLine());
    if(rows > 0 && cols > 0)
        break;
    else
        Console.WriteLine("Количество и строк и столбцов должно быть больше 0. Пожалуйста повторите попытку.");
}

while(true) 
{
    Console.Write("Введите индекс строки (начиная с 1): ");
    posI = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца (начиная с 1): ");
    posJ = Convert.ToInt32(Console.ReadLine());
    if(posI > 0 && posJ > 0)
        break;
    else
        Console.WriteLine("Индексы должны быть больше 0. Пожалуйста повторите попытку.");
}

PrintElement(CreateArray(rows, cols), posI, posJ);
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void ColumnsMeanValue(int[,] array)
{
    double meanValue = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            meanValue += array[i, j];
        }
        meanValue /= array.GetLength(0);
        Console.Write(Math.Round(meanValue, 2) + "; ");
        meanValue = 0;
    }
    Console.WriteLine();
}


int rows = 0, cols = 0;

while(true) 
{
    Console.Write("Введите количество строк (начиная с 1): ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов (начиная с 1): ");
    cols = Convert.ToInt32(Console.ReadLine());
    if(rows > 0 && cols > 0)
        break;
    else
        Console.WriteLine("Количество и строк и столбцов должно быть больше 0. Пожалуйста повторите попытку.");
}

ColumnsMeanValue(CreateArray(rows, cols));
*/
