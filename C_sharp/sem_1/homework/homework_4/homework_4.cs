// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;

if (N < 2)
{
    Console.WriteLine("нет чисел в данном диапазоне");
}
else
{
    while (i <= N)
    {
        Console.Write(i+" ");
        i = i + 2;
    }
}


