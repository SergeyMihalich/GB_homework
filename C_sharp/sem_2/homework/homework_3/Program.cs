// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

Console.Clear();

void SearchWeekend(int NumDay)
{
    if (NumDay >= 1 && NumDay <= 5)
    {
        Console.WriteLine("это будничный день");
    }
    else if (NumDay == 6 || NumDay == 7)
    {
        Console.WriteLine("это выходной день");
    }
    else
    {
        Console.WriteLine("такого дня в недели нет");
    }
}

Console.Write("Введите число: ");
SearchWeekend(int.Parse(Console.ReadLine()!));