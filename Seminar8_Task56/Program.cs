// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Заполняем массив
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix) // печатаем результат
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matrix[i,j]+" ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int MinSumRow( int [,] matrix)
{
    int outN = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow = sumRow + matrix[i,j];
        }
        if ( sumRow < sum )
        {
            sum = sumRow;
            outN = i; 
        }
    }
    return outN;
}

Console.Clear();
int n = ReadData("Количество строк: ");
int m = ReadData("Количество столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] array2D = Fill2DArray(n,m,10,1);
Print2DArray(array2D);
Console.WriteLine("________________");
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumRow(array2D) + 1}");
