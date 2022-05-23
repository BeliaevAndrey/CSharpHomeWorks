using System;

// Общие для первых двух задач методы

// Создание двумерного массива
int[,] CreateArray(int rowsAmt, int colsAmt, int minVal, int maxVal)
{
    int[,] array = new int[rowsAmt, colsAmt];
    for (int i = 0; i < rowsAmt; i++)
    {
        for (int j = 0; j < colsAmt; j++)
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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

    while (true)
    {
        Console.Write("Введите количество строк (начиная с 1): ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов (начиная с 1): ");
        cols = Convert.ToInt32(Console.ReadLine());
        if (rows > 0 && cols > 0)
            break;
        else
            Console.WriteLine("Количество и строк и столбцов должно быть больше 0. Пожалуйста повторите попытку.");
    }

    Console.Write("Введите нижнюю границу диапазона значений: ");
    int lowerValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхнюю границу диапазона значений: ");
    int upperValue = Convert.ToInt32(Console.ReadLine());

    int[] paramsOut = { rows, cols, lowerValue, upperValue };
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

/*
int LesserStringSum(int[,] matrix)
{
    int stringSum = 0, minStringSum = 0, rowIndex = 1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        stringSum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == 0)
            {                
                minStringSum += matrix[i, j];
                stringSum += matrix[i, j];
            }
            else
                stringSum += matrix[i, j];
        }
        if(minStringSum > stringSum)
        {
            rowIndex = i + 1;
            minStringSum = stringSum;
        }
     }
    return rowIndex;
}

int[] arrayParameters = ArrayParametersInput();
int result = LesserStringSum(CreateArray(arrayParameters[0],    // Rows
                                         arrayParameters[1],    // Columns
                                         arrayParameters[2],    // Lower value of a range
                                         arrayParameters[3]     // Upper value of a range
                                         ));

Console.WriteLine($"Наименьшая сумма элементов в {result} строке.");
*/

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1   2   3   4
// 12  13  14  5
// 11  16  15  6
// 10  9   8   7


int[,] CreateSpriralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int row = 0, column = 0, deltaCol = 1, deltaRow = 0, limit = 0, way = 0;
    // way: right (1-4) 0, down (5-7) 1, left (8-10) 2, up (11-12) 3, right(13-14) 4, down(15) 5, left(16) 6
    limit = n;

    for (int i = 0; i < m * n; i++)
    {
        array[row, column] = i + 1;

        limit--;
        if(limit == 0 && way%2 == 0)
        {
            limit = m - way / 2 - 1;
            (deltaCol, deltaRow) = (-deltaRow, deltaCol);   // swap axis
            way++;
        }
        if(limit == 0 && way%2 != 0)
        {
            limit = n - way / 2 -1;
            (deltaCol, deltaRow) = (-deltaRow, deltaCol);
            way++;
        }
        row += deltaRow;
        column += deltaCol;

    }

    return array;
}

int rowsTask3 =0, colsTask3 = 0;
while (true)
{
    Console.Write("Введите количество строк (начиная с 1): ");
    rowsTask3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов (начиная с 1): ");
    colsTask3 = Convert.ToInt32(Console.ReadLine());
    if (rowsTask3 > 0 && colsTask3 > 0)
        break;
    else
        Console.WriteLine("Количество и строк и столбцов должно быть больше 0. Пожалуйста повторите попытку.");
}

PrintArray(CreateSpriralArray(rowsTask3, colsTask3));

