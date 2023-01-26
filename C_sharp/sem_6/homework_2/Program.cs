// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double GetNumbers(string N)
{
    Console.WriteLine($"введите значение {N}");
    double Num = Convert.ToInt32(Console.ReadLine());
    return Num;
}

void GetCoordinates(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"две прямые пересекутся в точке: ({x}, {y})");
}

double b1 = GetNumbers("b1");
double k1 = GetNumbers("k1");
double b2 = GetNumbers("b2");
double k2 = GetNumbers("k2");

GetCoordinates(b1, k1, b2, k2);

