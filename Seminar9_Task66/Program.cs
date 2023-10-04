// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadData(string line) // вводим число N
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
bool DetectMaxMin(int m, int n) // Проверка на максимальное и минимальное
{
    return m > n;   
}

int SumDigitRec(int max, int min) // вывел сумму
{
    if ( min <= max )
    {
        return min + SumDigitRec(max,min + 1);
    }
    else
    {
        return 0;
    } 

}

int n = ReadData($"Введите число N : ");
int m = ReadData($"Введите число M : ");
Console.WriteLine( DetectMaxMin(m,n) ? SumDigitRec(m,n) : SumDigitRec(n,m));