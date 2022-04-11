/****************************************************************************************************
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
string separator = "\n***************************\n";    // \n (непроходили) литарал переноса строки 

int maximal, num0, num1;

Console.WriteLine("Task 1. Comparing two numbers\n");
Console.Write("Input first integer number: ");
num0 = Convert.ToInt32(Console.ReadLine());    // ввести и конвертировать строку в целое число, присвоить переменной
Console.Write("Input second integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
if(num0 > num1)
{
    maximal = num0;
}
else
{
    maximal = num1;
}

Console.WriteLine("Max value = " + maximal);
Console.WriteLine(separator);

/****************************************************************************************************
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Task 2 Comparing three numbers\n");

int maximal1, num3, num4, num5;

Console.Write("Input first integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());   // ввести и конвертировать строку в целое число, присвоить переменной
Console.Write("Input second integer number: ");
num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
num5 = Convert.ToInt32(Console.ReadLine());
if(num3 > num4)
{
    maximal1 = num1;
}
else
{
    maximal1 = num4;
}
if(maximal1< num5)
{
    maximal1 = num5;
}

Console.WriteLine("Max value = " + maximal1);
Console.WriteLine(separator);


/****************************************************************************************************
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Task 3. Checking if number is even or odd\n");
Console.Write("Input integer number: ");

int number = Convert.ToInt32(Console.ReadLine());  // ввести и конвертировать строку в целое число, присвоить переменной

if(number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}
Console.WriteLine(separator);

/****************************************************************************************************
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
// Вариант 1

Console.WriteLine("Task 4 (v1). Print even numbers in range from 1 to N\n");
Console.Write("Input posittive integer number (N >= 2): ");
int counter = 1;
int number1 = Convert.ToInt32(Console.ReadLine());    // ввести и конвертировать строку в целое число, присвоить переменной

if(number1 < 2)    // Проверка корректности ввода
{
    Console.WriteLine("Incorrect input: number is too small. Inrrupting.");
    System.Environment.Exit(0);    // Завершение процесса с кодом выхода 0 (процесс прошел успешно)
                                   // операционной системе. 
                                   // Прочитано в документации:
                                   // https://docs.microsoft.com/ru-ru/dotnet/api/system.environment.exit?view=net-6.0
}

while(counter <= number1)
{
    if(counter % 2 == 0)
    {
        Console.Write(counter);
        if(counter + 1 < number1)   // не выводить ',' после последнего символа
        {  
            Console.Write(", ");
        }
    }
    counter++;
}

Console.WriteLine();
Console.WriteLine(separator);

// Вариант 2 (число берется из варинта 1)

Console.WriteLine("Task 4 (v2). Print even numbers in range from 1 to N\n");

string line = "";   // объявить строковую переменную
counter = 1;    // сбросить счетчик
while(counter <= number1)
{
    if(counter % 2 == 0)
    {
        line += Convert.ToString(counter);  // конкатенация с присваиванием, конвертация типа int в string
        if(counter + 1 < number1)   // не выводить ',' после последнего символа
        {  
            line += ", ";   // конкатенация с присваиванием
        }
    }
    counter++;
}

Console.WriteLine(line);
Console.WriteLine(separator);

// Вариант 3 (число берется из варинта 1)

Console.WriteLine("Task 4 (v3). Print even numbers in range from 1 to N\n");

line = "";   // очистить переменную
counter = number1;    // сбросить счетчик
while(counter > 1)
{
    if(counter % 2 == 0)
    {
        line = Convert.ToString(counter) + line;  // конкатенация в обратном порядке, конвертация типа int в string
        if(counter > 2)    // не выводить ',' перед первым символом
            line = ", " + line;   // конкатенация в обратном порядке
    }
    counter--;
}

Console.WriteLine(line);
Console.WriteLine(separator);
