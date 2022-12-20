// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int rez = num % 2;

if (num % 2 == 0) 
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
