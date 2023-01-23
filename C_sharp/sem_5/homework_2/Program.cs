//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0


Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];




void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100,100);
    }
}
int sum_ellements(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i+=2)
    {
        sum += numbers[i];
    }
    return sum;
    
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
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
Console.WriteLine("массив: ");
PrintArray(numbers);
Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum_ellements(numbers)}");