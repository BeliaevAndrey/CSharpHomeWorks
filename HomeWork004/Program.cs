// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] FillArray(int len)
{
    int[] outarr = new int[len];
    for(int i = 0; i < len; i++)
    {
        outarr[i] = new Random().Next(99, 1000);
    }
    return outarr;
}

int CountEven(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;
    }
    return count;
}

Console.Write("Задайте длину массива: ");
int arlen = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(arlen);
Console.WriteLine("[{0}] -> {1}", string.Join(", ", array), CountEven(array));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] FillArray(int len)
{
    int[] outarr = new int[len];
    for(int i = 0; i < len; i++)
    {
        outarr[i] = new Random().Next(0, 50);
    }
    return outarr;
}

int SumOddPositions(int[] arr)
{
    
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}

Console.Write("Задайте длину массива: ");
int arlen = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(arlen);
Console.WriteLine("[{0}] -> {1}", string.Join(", ", array), SumOddPositions(array));
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
double[] FillArray(int len)
{
    double[] outarr = new double[len];
    for(int i = 0; i < len; i++)
    {
        outarr[i] = Convert.ToDouble(new Random().Next(0, 101));
    }
    return outarr;
}

double DiffMaxMin(double[] arr)
{
    double max = arr[0], min = arr[0];
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) max = arr[i];
        if(min > arr[i]) min = arr[i];
    }
    Console.WriteLine("max = " + max);
    Console.WriteLine("min = " + min);
    return max - min;
}

Console.Write("Задайте длину массива: ");
int arlen = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(arlen);
Console.WriteLine("[{0}] -> {1}", string.Join(" ", array), DiffMaxMin(array));
*/
