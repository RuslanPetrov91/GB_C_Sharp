﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message)
{
    Console.Write(message);                     // печатается на консоль
    return int.Parse(Console.ReadLine()!);      // возврат
}

int LengthNumber(int arg)                       // Определяет длину числа
{
    int lengthNumber = 0;
    while (arg > 0)
    {
        arg /= 10;
        lengthNumber += 1;
    }
    return lengthNumber;
}

int number = GetNumber("Введите число => ");

int sum = LengthNumber(number);
System.Console.WriteLine(sum);