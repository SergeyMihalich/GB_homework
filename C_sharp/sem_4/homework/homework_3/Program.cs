// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int getUserData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(msg);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] getArray(int len, int start, int end)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

string showArray(int[] array)
{
    string arr = $"[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            arr += $"{array[i]},";
        }
        else
        {
            arr += $"{array[i]}]";

        }
    }
    return arr;
}

int start = getUserData("задайте нижний порог чисел массива ");
int end = getUserData("задайте верхний порог чисел массива ");
int length = getUserData("задайте размерность массива ");

int[] array = getArray(length, start, end);
Console.WriteLine(showArray(array));


