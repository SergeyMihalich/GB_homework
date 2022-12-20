
// ЗАДАЧА 1
Console.Clear();

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);
int sqr = num_2 * num_2;

if(sqr == num_1)
{
    Console.WriteLine("да");     
}
else
{
    Console.WriteLine("нет");
}