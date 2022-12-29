// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int getUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void getCubeValue(int num)
{
    for (int i = 0; i < num; i++)
    {
        if (i < num - 1)
        {
            Console.Write($"{Math.Pow(i,3)}, ");
        }
        else
        {
            Console.Write($"{Math.Pow(i,3)}");
        }
        
    }
}

int num = getUserValue("введите число") + 1;
getCubeValue(num);