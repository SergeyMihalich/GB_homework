// задача 22


Console.Clear();

int getUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int num = getUserValue("введите число") + 1;

for (int i = 0; i < num; i++)
{
    Console.Write($"{i * i} ");
}