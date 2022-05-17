﻿using System;

// Общие для всех задач методы

// Создание двумерного массива
int[,] CreateArray(int rowsAmt, int colsAmt, int minVal, int maxVal)
{
    int[,] array = new int[rowsAmt, colsAmt];
    for(int i = 0; i < rowsAmt; i++)
    {
        for(int j = 0; j < colsAmt; j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    PrintArray(array);
    Console.WriteLine();
    return array;
}

// Вывод двумерного массива
void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Запрос параметров массива
int[] ArrayParametersInput()
{
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

    Console.Write("Введите нижнюю границу диапазона значений: ");
    int lowerValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхнюю границу диапазона значений: ");
    int upperValue = Convert.ToInt32(Console.ReadLine());

    int[] paramsOut = {rows, cols, lowerValue, upperValue};
    return paramsOut;

}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1   4   7   2
// 5   9   2   3
// 8   4   2   4

// В итоге получается вот такой массив:
// 1   2   4   7
// 2   3   5   9
// 2   4   4   8

/*
int[,] SortArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPos = j;
            for(int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if(matrix[i, k] < matrix[i, minPos])
                {
                    minPos = k;
                }
            }
            
            (matrix[i, minPos], matrix[i, j]) = (matrix[i, j], matrix[i, minPos]);  // Использовал кортеж, по аналогии с Python
            
            // int tmp = matrix[i, minPos];
            // matrix[i, minPos] = matrix[i, j];
            // matrix[i, j] = tmp;
        }
    }
    return matrix;
}

int[] arrayParameters = ArrayParametersInput();

PrintArray(SortArray(CreateArray(arrayParameters[0],    // Rows amount
                                 arrayParameters[1],    // Columns amount
                                 arrayParameters[2],    // Lower range value
                                 arrayParameters[3]     // Upper range value
                                 )));

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1   4   7   2
// 5   9   2   3
// 8   4   2   4
// 5   2   6   7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int LesserStringSum(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    int stringSum = 0, nextStringSum = 0, rowIndex = 1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        if(nextStringSum < stringSum)
            rowIndex = i + 1;
        nextStringSum = 0;
        stringSum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            stringSum += matrix[i, j];
            if(i < matrix.GetLength(0) - 1)
                nextStringSum += matrix[i + 1, j];
        }
        sums[i] = stringSum;
     }
    Console.WriteLine(string.Join(", ", sums));
    return rowIndex;
}

int[] arrayParameters = ArrayParametersInput();
int result = LesserStringSum(CreateArray(arrayParameters[0],
                                         arrayParameters[1],
                                         arrayParameters[2],
                                         arrayParameters[3]
                                         ));

Console.WriteLine($"Наименьшая сумма элементов в {result} строке.");

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1   2   3   4
// 12  13  14  5
// 11  16  15  6
// 10  9   8   7


