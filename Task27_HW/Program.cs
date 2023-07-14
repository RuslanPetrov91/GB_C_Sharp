// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Prompt("Введите число => ");
int result = 1;

int Prompt(string message)
{
    Console.Write(message);                     // печатается на консоль
    int num = int.Parse(Console.ReadLine()!);   // конвертируется
    return num;                                 // возврат
}

int CubeNumber(int number, int result)
{
    while (result <= number)
    {
        System.Console.WriteLine($"{result * result * result}");
        result++;
    }

    return result;
}

result = CubeNumber(number, result);