// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " \t");
            }
            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        // System.Random rnd = new System.Random();
        int[,] matrix = new int[n, m];
        int currentNumber = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] += currentNumber;
                currentNumber += k;
            }
        }
        return matrix;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int [] results = new int [2];
        if (rowPosition <= matrix.GetLength(0) && columnPosition <= matrix.GetLength(1))
            {
               results [0] = matrix[rowPosition -1 , columnPosition -1];
               results [1] = 0;
            }
        else 
            {
                results[0] = 0;
                results[1] = 0;
            }
        return results;

    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        int res = 0;
        if ( results[0] == 0 )
        {
        Console.WriteLine("There is no such index");
        }
        else
        {
        res = results[0];
        Console.WriteLine($"The number in [{X}, {Y}] is {res}");
        }

    }


// Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
