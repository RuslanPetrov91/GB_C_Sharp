// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Prompt("Введите первую точку X => ");
int y1 = Prompt("Введите первую точку Y => ");
int z1 = Prompt("Введите первую точку Z => ");
int x2 = Prompt("Введите вторую точку X => ");
int y2 = Prompt("Введите вторую точку Y => ");
int z2 = Prompt("Введите вторую точку Z => ");

int Prompt(string message)
{
    Console.Write(message);                     // печатается на консоль
    int num = int.Parse(Console.ReadLine()!);   // конвертируется
    return num;                                 // возврат
}

double Summ(int x, int y, int z)
{
    double temp = (x * x) + (y * y) + (z * z);
    return Math.Sqrt(temp);
}

double distance = Summ(x1 - x2, y1 - y2, z1 - z2);
System.Console.WriteLine($"Расстояние между двумя точками равно {distance}");