// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Minimum3sign(int number)
{
    if (number >= 100)
    {
        return true;
    }

    System.Console.WriteLine("Третьей цифры нет");
    return false;
}

int num = ReadInt("Введите число > ");
int value = 0;

if (Minimum3sign(num))
{
    while (num >= 100)
    {
        value = num % 10;
        num = num / 10;
    }
    System.Console.WriteLine($"Третья цифра числа равна {value}");
}