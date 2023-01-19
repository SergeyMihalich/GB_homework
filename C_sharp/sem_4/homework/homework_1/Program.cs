// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int getUserData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(msg);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double getNum(int numI, int end)
{
    int num = 1;
    for (int i = 0; i < end; i++)
    {
        num *= numI;
    }
    return num;
}

void showData(string msgStart, double data)
{
    Console.Write(msgStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int numI = getUserData("Введите число для возведения в степень ");
int stepen = getUserData("Введите число степени ");
double num = getNum(numI, stepen);
showData($"числел {numI} в степни {stepen} = ",num);
