// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Вариант 1.
/*
double[] digitsInput(double num)
{
    double[] digits = new double[num];
    for(double i = 0; i < num; i++)
    {
        Console.Write($"введите число {i+1}/{num}: ");
        digits[i] = Convert.Todouble32(Console.ReadLine());
    }
    return digits;
}

void CountPositive(double[] array)
{
    double count = 0;
    for(double i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine($"{string.Join(", ", array)} -> {count}");
}

Console.Write("Сколько чисел планируется ввести? ");
double amt = Convert.Todouble32(Console.ReadLine());
double[] nums = digitsInput(amt);
CountPositive(nums);
*/

// Вариант 2.
/*
void CountPositive(double num)
{
    double count = 0;
    double[] digits = new double[num];
    for(double i = 0; i < num; i++)
    {
        Console.Write($"введите число {i+1}/{num}: ");
        digits[i] = Convert.Todouble32(Console.ReadLine());
        if(digits[i] > 0) count++;
    }

    Console.WriteLine($"{string.Join(", ", digits)} -> {count}");
}

Console.Write("Сколько чисел планируется ввести? ");
double amt = Convert.Todouble32(Console.ReadLine());
CountPositive(amt);
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
string DecToBin(double num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = Convert.ToString(num % 2) + result;
        num /= 2;
    }
    return result;
}

Console.Write("Введите число для конвертации: ");
double number = Convert.Todouble32(Console.ReadLine());
Console.WriteLine($"{number} -> {DecToBin(number)}");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

//************************************************************************************************
// Решал вычитанием 2-го уравнения из первого с последующей подстановкой 'x' для вычисления 'y'.
// В примере ошибка, получается (-0,5; -0,5).
// Программу проверил с коэффициентами из разбора подобной системы уравнений в интернете -- все сошлось.
//************************************************************************************************

/*
double[] CrossPodouble(double k1, double b1, double k2, double b2)
{
    double[] coords = new double[2];

    coords[0] = -((b1-b2) / (k1-k2));
    coords[1] = k2 * coords[0] + b2;

    return coords;
}


Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] result = CrossPodouble(k1, b1, k2, b2);
Console.Write($"k1={k1}, b1={b1}, k2={k2}, b2={b2} -> ");
Console.WriteLine("({0})", string.Join("; ", result));
*/
