// задача 20
Console.Clear();

int getUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getCoordinate(int Ax, int Ay, int Bx, int By)
{
    double result = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2));
    return result;
}

int Ax = getUserValue("введите A x");
int Ay = getUserValue("введите A y");
int Bx = getUserValue("введите B x");
int By = getUserValue("введите B y");

double Coordinate = getCoordinate(Ax, Ay, Bx, By);
Console.WriteLine(Coordinate);
