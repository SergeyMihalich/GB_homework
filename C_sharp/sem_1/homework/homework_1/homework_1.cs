// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
Console.Clear();

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);

if (num_1 > num_2)
{
    Console.WriteLine($"первое число {num_1} больше чем второе {num_2}");
}
else if (num_1 < num_2)
{
    Console.WriteLine($"второе число {num_2} больше чем первое {num_1}");
}
else
{
    Console.WriteLine("введены не корректные значения");
}