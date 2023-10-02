// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultipliedMatrix( int[,] matrix1, int[,]matrix2 )
{
    int[,] multipliedArr = new int[matrix1.GetLength(0),matrix2.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                multipliedArr[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }

    return multipliedArr;
}


Console.Clear();
int n = ReadData("Количество строк: ");
int m = ReadData("Количество столбцов: ");

int[,] array2D1 = Fill2DArray(n,m,10,1);
int[,] array2D2 = Fill2DArray(m,n,10,1);
Console.WriteLine("Исходная матрица 1");
Print2DArray(array2D1);
Console.WriteLine("________________");
Console.WriteLine("Исходная матрица 2");
Print2DArray(array2D2);
Console.WriteLine("________________");
Console.WriteLine(" Перемноженная матрица");
int[,] array2DMultiplied= MultipliedMatrix(array2D1, array2D2);
Print2DArray(array2DMultiplied);
