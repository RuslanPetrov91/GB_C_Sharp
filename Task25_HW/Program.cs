// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = Prompt("Введите пятизначное число => ");

int Prompt(string message)
{
    Console.Write(message);                     // печатается на консоль
    int num = int.Parse(Console.ReadLine());    // конвертируется
    return num;                                 // возврат
}

bool FiveDigitNumber(int number)
{
    if (number <= 99999 && number >= 10000)
    {
        return true;
    }
    System.Console.WriteLine("Вы ввели не пятизначное число");
    return false;
}

void Palindrome(int num)
{
    if (num % 10 == num / 10000 % 10 && num / 10 % 10 == num / 1000 % 10)
    {
        System.Console.WriteLine($"Палиндром");
    }
    else
    {
        System.Console.WriteLine("Не палиндром");
    }
}

 if (FiveDigitNumber(num))
 {
   Palindrome (num);
 }