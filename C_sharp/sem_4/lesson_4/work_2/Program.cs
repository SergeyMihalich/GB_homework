// задача 26

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
        num = num / 10;
        numOfDigit++;

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