using System;

// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

/*
// Вариант 1.

int VowelCount(string[] array)
{
    int count = 0;
    char[] vowels = "aeiouy".ToCharArray();

    foreach(string word in array)
        foreach(char letter in vowels)
            if(word.ToLower().StartsWith(letter))
                count++;

    return count;
}

string[] firstTaskArray1 = { "qwe", "wer", "ert", "rty", "tyu"};
Console.Write("{" + string.Join(", ", firstTaskArray1) + "} -> ");
Console.WriteLine(VowelCount(firstTaskArray1));
Console.WriteLine();

string[] firstTaskArray2 = { "ewq", "wer", "Ert", "ytr", "tyu"};
Console.Write("{" + string.Join(", ", firstTaskArray2) + "} -> ");
Console.WriteLine(VowelCount(firstTaskArray2));
Console.WriteLine();

*/

// Вариант 2.

/*

int VowelCount2(string[] array)
{
    int count = 0;
    string vowels = "aeiouy";

    for(int i = 0; i < array.Length; i++)
    {    
        for(int j = 0; j < vowels.Length; j++)
        {
            // Console.WriteLine(array[i].ToLower()[0] + " " + array[i] + " " + vowels[j]);
            if(array[i].ToLower()[0] == vowels[j])
            {
                // Console.WriteLine(array[i][0] + " " + vowels[j]);
                count++;
            }
        }
    }
    return count;
}

string[] firstTaskArray1 = { "qwe", "wer", "ert", "rty", "tyu"};
Console.Write("{" + string.Join(", ", firstTaskArray1) + "} -> ");
Console.WriteLine(VowelCount2(firstTaskArray1));
Console.WriteLine();

string[] firstTaskArray2 = { "ewq", "wer", "Ert", "ytr", "tyu"};
Console.Write("{" + string.Join(", ", firstTaskArray2) + "} -> ");
Console.WriteLine(VowelCount2(firstTaskArray2));
Console.WriteLine();

*/

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

/*

string[] PairConcat(string[] array)
{
    int arLen = array.Length / 2 + array.Length % 2;
    string[] outArray = new string[arLen];
    for(int i = 0, j = 0; i < array.Length - 1; i += 2, j++)
    {
        outArray[j] = (array[i] + array[i + 1]);
        if(array.Length % 2 != 0 && j == arLen - 2)
        {
            outArray[arLen - 1] = array[array.Length-1];
            break;
        }
    }
    return outArray;
}

string[] testArray = { "qwe", "wer",
                       "ert", "rty",
                       "tyu", "yui"};

string[] testArray2 = { "qwe", "wer",
                        "ert", "rty", 
                        "tyu", "yui", 
                        "END"  
                     };

string[] testArray3 = { "Jo", "hn",
                        "Smi", "th", 
                        "Har", "ry", 
                        "Bil", "ly",
                        "Pad", "dy", 
                        "Chris", "ten", 
                        "Pe", "ter",
                        "Mic", "roft", 
                        "Mich", "ael", 
                        "Jo", "han",
                        "Ter", "ence", 
                        "Jen", "nifer",  
                        "Ala", "bama",
                        "Oh", "io", 
                        "Wis", "consin", 
                        "Wyo", "ming",
                        "New-", "York", 
                        "Nev", "ada", 
                        "END"  
                     };


Console.WriteLine("{\"" + string.Join("\", \"", testArray)+ "\"" + " -> " + "\"" + string.Join("\", \"", PairConcat(testArray)) + "\"}");

Console.WriteLine();
Console.WriteLine("{\"" + string.Join("\", \"", testArray2)+ "\"" + "} -> {" + "\"" + string.Join("\", \"", PairConcat(testArray2)) + "\"}");

Console.WriteLine();
Console.WriteLine("{\"" + string.Join("\", \"", testArray3)+ "\"" + "} \n {" + "\"" + string.Join("\", \"", PairConcat(testArray3)) + "\"}");

*/
