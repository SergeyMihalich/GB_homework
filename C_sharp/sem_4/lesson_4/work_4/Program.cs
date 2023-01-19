// задача 30
Console.Clear();

int[] getArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void showArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}]");

        }
    }

}

int[] array = getArray(8);
showArray(array);


