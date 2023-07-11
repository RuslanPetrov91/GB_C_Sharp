// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1 => ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2 => ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    System.Console.WriteLine($"Число {number1} большее, число {number2} меньшее");
}
else
{
    System.Console.WriteLine($"Число {number1} меньшее, число {number2} большее");
}