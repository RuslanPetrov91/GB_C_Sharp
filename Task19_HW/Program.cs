//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int num = Prompt("Введите число обозначающее день недели (от 1 до 7) => ");

int Prompt(string message)
{
    Console.Write(message);                     // печатается на консоль
    int num = int.Parse(Console.ReadLine());    // конвертируется
    return num;                                 // возврат
}

bool DayOfTheWeekSearch(int number)
{
    if (number >= 1 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Неправильный ввод");
    return false;
}

bool DayOff(int number)
{
    if (number >= 6 && number <= 7)
    {
        System.Console.WriteLine("да");
        return true;
    }
    System.Console.WriteLine("нет");
    return false;
}

if (DayOfTheWeekSearch(num))
{
    if (DayOff(num));
}