// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int getUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getCoordinate(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double result = Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay),2) + Math.Pow((Az - Bz),2));
    return result;
}

int Ax = getUserValue("введите A x");
int Ay = getUserValue("введите A y");
int Az = getUserValue("введите A z");
int Bx = getUserValue("введите B x");
int By = getUserValue("введите B y");
int Bz = getUserValue("введите B z");

double distance = getCoordinate(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine(distance);