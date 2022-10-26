﻿string[] GetString()
{
    Console.WriteLine("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");

}

int GetLength(string[] arr, int n)
{
    int len = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= n)
            len++;
    }
    return len;
}

string[] FindLess(string[] inputMassiv, int n)
{
    string[] result = new string[GetLength(inputMassiv, n)];
    for (int i = 0, j = 0; i < inputMassiv.Length; i++)
    {
        if (inputMassiv[i].Length <= n)
        {
            result[j] = inputMassiv[i];
            j++;
        }
    }
    return result;
}

string[] input = GetString();
string[] output = FindLess(input, 3);
Console.WriteLine();
Console.WriteLine("Исходный массив -> Итоговый массив, состоящий из 3-х и менее символов: ");
Console.WriteLine($"{string.Join(", ", input)} -> {string.Join(", ", output)}");
Console.WriteLine();