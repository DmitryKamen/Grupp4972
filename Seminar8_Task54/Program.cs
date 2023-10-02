// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void BubbleMethod (int[] arr) // сортировка пузырьком по убыванию  - if ( arr[j] < arr[j + 1])
{
    int temp = 0;
    for ( int i = 0; i < arr.Length; i++)
    {
        for ( int j = 0; j < arr.Length - 1 - i; j++ )
        {
            if ( arr[j] < arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1]= temp;
            }
        }    
    }
}

void SortArray(int[,]array) // сортировка строк двумерного массива по убыванию
{
    int[] buf = new int[array.GetLength(1)]; 
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            buf[j] = array[i,j];
        }
        BubbleMethod (buf);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = buf[j];
        }

    }

}

Console.Clear();
int n = ReadData("Количество строк: ");
int m = ReadData("Количество столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] array2D = Fill2DArray(n,m,10,1);
Print2DArray(array2D);
Console.WriteLine("________________");
Console.WriteLine("Отсортированная матрица");
SortArray(array2D);
Print2DArray(array2D);