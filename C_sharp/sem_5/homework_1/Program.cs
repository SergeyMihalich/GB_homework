﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void sum_ellements(int[] numbers)
{
    int count = 0;
    for (int x = 0; x < numbers.Length; x++)
    {
    if (numbers[x] % 2 == 0)
    count++;
    }
    Console.WriteLine($"{numbers.Length} чисел, из них {count} четных");
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
Console.Write("В массиве: ");

PrintArray(numbers);
sum_ellements(numbers);