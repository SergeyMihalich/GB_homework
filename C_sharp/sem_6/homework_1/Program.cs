// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Необходимое количество чисел: ");
int CountNum = Convert.ToInt32(Console.ReadLine());

int[] GetNumbers()
{
    int[] InputNumbers = new int [CountNum];
    for (int i = 0; i < CountNum; i++)
    {
        Console.Write($"Введите число №{i+1}: ");
        InputNumbers[i] = Convert.ToInt32(Console.ReadLine()!);
    }
    return InputNumbers;
}

void CountNumbers(int[] InputNumbers)
{
    int sum = 0;
    for (int i = 0; i < InputNumbers.Length; i++)
    {
        if (InputNumbers[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"количество значений больше 0 = {sum}");
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
        if (i != numbers.Length - 1)
        {
            Console.Write($"{numbers[i]}, ");
        }
        else
        {
            Console.Write($"{numbers[i]}]");
        }
    Console.WriteLine();
}

int[] InputNumbers = GetNumbers();
CountNumbers(InputNumbers);
PrintArray(InputNumbers);
