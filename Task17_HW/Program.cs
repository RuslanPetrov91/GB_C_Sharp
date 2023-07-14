// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool ThreeDigitNumber(int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Вы ввели не трехзначное число");
    return false;
}

int num = ReadInt("Введите число > ");
int value = 0;

if (ThreeDigitNumber(num))
{
    num = num / 10;
    value = num % 10;
    System.Console.WriteLine($"Вторая цифра числа равна {value}");
}