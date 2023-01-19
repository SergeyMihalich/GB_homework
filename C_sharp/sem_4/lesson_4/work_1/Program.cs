// задача 24

int getUserData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(msg);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i < end; i++)
    {
        sum += i;
    }
    return sum;
}

void showData(string msgStart, int data)
{
    Console.Write(msgStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int end = getUserData("Введите число А для получения суммы ");
int sum = getSumOfRange(1, end);
showData($"сумма числел от 1 до {end} = ",sum);