// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int getUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void checkPolindrome(int num)
{
    int n1 = num / 10000;
    int n2 = num / 1000 % 10;
    int n4 = num % 100 / 10;
    int n5 = num % 10;

    if (n1 == n5 && n2 == n4)
    {
        Console.WriteLine("полиндром");
    }
    else
    {
        Console.WriteLine("не полиндром");
    }
}

int num = getUserValue("введите число ");
checkPolindrome(num);