// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третие число: ");
int num_3 = int.Parse(Console.ReadLine()!);

if (num_1 >= num_2 && num_1 >= num_3)
{
    Console.WriteLine(num_1);
}
else if (num_2 >= num_1 && num_2 >= num_3)
{
    Console.WriteLine(num_2);
}
else if (num_3 >= num_2 && num_3 >= num_1)
{
    Console.WriteLine(num_3);
}