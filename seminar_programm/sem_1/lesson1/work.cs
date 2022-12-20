
// ЗАДАЧА 0
// Console.Clear();

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int sqr = num * num;

// Console.WriteLine($"Квадрат числа {num} равен {sqr}");


// ЗАДАЧА 1
// Console.Clear();

// Console.Write("Введите первое число: ");
// int num_1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num_2 = int.Parse(Console.ReadLine()!);
// int sqr = num_2 * num_2;

// if(sqr == num_1)
// {
//     Console.WriteLine("да");     
// }
// else
// {
//     Console.WriteLine("нет");
// }


// ЗАДАЧА 3
// Console.Clear();

// Console.Write("Введите день недели: ");
// int num = int.Parse(Console.ReadLine()!);


// if(num == 1)
// {
//    Console.WriteLine("понедельник");
// }
// else if(num == 2)
// {
//    Console.WriteLine("вторник");
// }
// else if(num == 3)
// {
//    Console.WriteLine("среда");
// }
// else if(num == 4)
// {
//    Console.WriteLine("четверг");
// }
// else if(num == 5)
// {
//    Console.WriteLine("пятница");
// }
// else if(num == 6)
// {
//    Console.WriteLine("суббота");
// }
// else if(num == 7)
// {
//    Console.WriteLine("воскресенье");
// }
// else if(num < 1 || num > 7)
// {
//    Console.WriteLine("такого дня в недели нет");
// }


// ЗАДАЧА 5
// Console.Clear();

// Console.WriteLine("Введите число: ");
// int N_1 = int.Parse(Console.ReadLine()!);
// int N_2 = -N_1;

// while (N_2 <= N_1)
// {
//     Console.Write(N_2+" ");  
//     N_2++;
// }

// ЗАДАЧА 7
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    num = num * -1;
}
Console.Write(num%10);