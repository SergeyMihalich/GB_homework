// задача 17

Console.Clear();

int GetUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetQuarterNumber(int x, int y)
{
    int Quarter = 0;
    if (x > 0 && y > 0)
    {
        Quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        Quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        Quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        Quarter = 4;
    }
    return Quarter;
}


int UserX = GetUserValue("введите X");
int UserY = GetUserValue("введите Y");
int Quarter = GetQuarterNumber(UserX, UserY);
if (Quarter > 0)
{
    Console.WriteLine($"точка [{UserX},{UserY}] наодится в {Quarter} четверти");
}
else
{
    Console.WriteLine($"точка [{UserX},{UserY}] наодится на оси координат");
}