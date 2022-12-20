
// ЗАДАЧА 3
Console.Clear();

Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine()!);


if(num == 1)
{
   Console.WriteLine("понедельник");
}
else if(num == 2)
{
   Console.WriteLine("вторник");
}
else if(num == 3)
{
   Console.WriteLine("среда");
}
else if(num == 4)
{
   Console.WriteLine("четверг");
}
else if(num == 5)
{
   Console.WriteLine("пятница");
}
else if(num == 6)
{
   Console.WriteLine("суббота");
}
else if(num == 7)
{
   Console.WriteLine("воскресенье");
}
else if(num < 1 || num > 7)
{
   Console.WriteLine("такого дня в недели нет");
}
