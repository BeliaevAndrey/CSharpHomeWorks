// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Power(int Bs, int Dg)
{
    int result = Bs;
    for(int i = 1; i < Dg; i++)
    {
        result *= Bs; 
    }
    return result;
}

Console.Write("Введите число: ");
int Base = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int Degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Base}, {Degree} -> {Power(Base, Degree)}");
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int SumDigits(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> {SumDigits(number)}");
*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] GenArray(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if(i < arr.Length-1) Console.Write(", ");
    }
    
    Console.Write(" -> [");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if(i < arr.Length-1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

Console.Write("Введите размер массива: ");          // В задаче указано 8 элементов, а в примерах произвольное количество
int number = Convert.ToInt32(Console.ReadLine());

PrintArray(GenArray(number));
*/
