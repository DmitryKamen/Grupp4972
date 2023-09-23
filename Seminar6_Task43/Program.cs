// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double[] IntersectionPoint (int b1, int b2, int k1, int k2 )
{
    double[] xy = new double[2];
    xy[0] = (double) - (b1 - b2)/(k1 - k2);
    xy[1] = k1 * xy[0] + b1;
    return xy;
}

// void PrintResult(string msg, double x, double y)
// {
//     Console.WriteLine(msg, x, y);
// }

int b1 = ReadData("Введите b1: ");
int b2 = ReadData("Введите b2: ");
int k1 = ReadData("Введите k1: ");
int k2 = ReadData("Введите k2: ");
double[]xy = IntersectionPoint(b1,b2,k1,k2);
double x = xy[0];
double y = xy[1];
Console.WriteLine(" Точка пересеченияя равна - " + "(" + x + ";"+ y + ")");