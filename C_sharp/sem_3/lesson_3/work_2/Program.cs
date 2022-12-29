// задача 18

Console.Clear();

int GetUserValue(string masssege)
{
    Console.WriteLine(masssege);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string getRangeFromQuarter(int quarter)
{
    string result = $"диапазон значений в {quarter} четверти ";
    switch (quarter)
    {
        case 1:
        {
            result += "x > 0 и y > 0";
            break;
        }
        case 2:
        {
            result += "x < 0 и y > 0";
            break;
        }
        case 3:
        {
            result += "x < 0 и y < 0";
            break;
        }
        case 4:
        {
            result += "x > 0 и y < 0";
            break;
        }
        default:
        {
            result = $"такой четверти не существует";
            break;
        }
    }
    return result;
}

int quarter = GetUserValue("введите номер четверти ");
string rengeDiscription = getRangeFromQuarter(quarter);
Console.WriteLine(rengeDiscription);