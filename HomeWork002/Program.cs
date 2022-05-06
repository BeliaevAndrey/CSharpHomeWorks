// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int FindSecond(int n)
{
    return n/10%10;
}

Console.Write("Введите 3-х значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while(num / 100 <= 0 || num / 100 > 10)
{
    Console.Write("Введено не 3-х значное число, пожалуйста попробуйте еще раз: ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.Write(num + " -> ");
Console.WriteLine(FindSecond(num));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Eliminate(int n)
{
    if(n/100 <=0)
    {
        Console.WriteLine("третьей цифры нет"); 
    }
    else
    {

        for(int i=0; i<2; i++)
        {
            n = n / 10;
        }
        Console.WriteLine(n%10);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + " -> ");
Eliminate(num);
