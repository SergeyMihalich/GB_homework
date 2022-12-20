
// ЗАДАЧА 7
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    num = num * -1;
}
Console.Write(num%10);