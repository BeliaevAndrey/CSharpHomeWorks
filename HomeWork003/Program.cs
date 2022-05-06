// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Вариант 1
/*
int[] Cubes(int num)
{
    Console.WriteLine("num = " + num);
    int[] result = new int[num];
    for(int i = 0; i < num; i++)
    {
        result[i] = Convert.ToInt32(Math.Pow(i+1, 3));
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write(arr.Length + " -> ");   
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if(i < arr.Length - 1) Console.Write(", "); 
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
int limit = Convert.ToInt32(Console.ReadLine());
PrintArray(Cubes(limit));
*/
// Вариант 2

void Cubes(int num)
{
    Console.WriteLine("num = " + num);
    int[] result = new int[num];
    for(int i = 0; i < num; i++)
    {
        result[i] = Convert.ToInt32(Math.Pow(i+1, 3));
        // Console.Write($"{result[i]}, ");
    }
    return result;
}
