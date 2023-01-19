// задача 28

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
    int sum = 1;
    for (int i = start; i <= end; i++)
    {
        sum *= i;
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

int end = getUserData("Введите число А для получения результата ");
int sum = getSumOfRange(1, end);
showData($"произведение числел от 0 до {end} = ",sum);