// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void RandomNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}

int Get_min(int[] numbers)
{
    int min = Int32.MaxValue;
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] < min)
        {
            min = numbers[z];
        }
    }
    return min;
}
int Get_max(int[] numbers)
{
    int max = Int32.MinValue;
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
        {
            max = numbers[z];
        }
    }
    return max;
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

RandomNumbers(numbers);
Console.Write("массив: ");
PrintArray(numbers);
int max = Get_max(numbers);
int min = Get_min(numbers);
Console.WriteLine($"всего {numbers.Length} чисел. Значения - максимальное {max}, минимальное {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением {max - min}");