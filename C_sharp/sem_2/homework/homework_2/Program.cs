// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

Console.Clear();

// int GetNumberFromRange(int start, int end)
// {
//     int number = new Random().Next(start, end + 1);
//     return number;
// }

void SearchThirdNumber(int number)
{
    int GetNumber = number;
    if (number < 0)
    {
        GetNumber = number * (-1);
    }
    string num = GetNumber.ToString();
    if (num.Length < 3)
    {
        Console.WriteLine($"у числа {number} нет третьего символа");
    }
    else
    {
        String LenNumStr = "1";
        LenNumStr += new String('0', num.Length - 2 - LenNumStr.Length);
        int LenNumInt = int.Parse(LenNumStr!);
        int ThirdNumber = GetNumber / LenNumInt % 10;

        Console.WriteLine($"у числа {number} третий символ {ThirdNumber}");
    }
}


// SearchThirdNumber(GetNumberFromRange(-99999999, 99999999));
Console.Write("Введите число: ");
SearchThirdNumber(int.Parse(Console.ReadLine()!));


