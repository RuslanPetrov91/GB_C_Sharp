﻿// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет

Console.Write("Введите число 1 => ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 => ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2)
{
    System.Console.WriteLine($"Число {number1} является квадратом {number2}");
}
else
{
    System.Console.WriteLine($"Число {number1} не является квадратом {number2}");
}