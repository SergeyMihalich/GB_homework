// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int getUserData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(msg);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getNumOfDigit(int num)
{
    int numOfDigit = 0;
    while (num > 0)
    {
        int numI = num % 10;
        num = num / 10;
        numOfDigit += numI;

    }
    return numOfDigit;
}

void showData(string msgStart, int data)
{
    Console.Write(msgStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int num = getUserData("Введите число ");
int numOfDigit = getNumOfDigit(num);
showData($"в числе {num} ", numOfDigit);