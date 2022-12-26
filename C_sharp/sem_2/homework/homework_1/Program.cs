// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int TwoNumberGettingNumbers(int number)
{
    int digit = number / 10 % 10;
    return digit;
}

int RandomNumber = GetNumberFromRange(100, 999);
int TwoNumber = TwoNumberGettingNumbers(RandomNumber);
Console.WriteLine($"вторая цифрв числа {RandomNumber} равна {TwoNumber}");