// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,,] Fill3DArray(int RowX, int RowY, int RowZ, int topBorder, int downBorder) // Заполняем массив
{
    int[,,] array3D = new int[RowX, RowY, RowZ];
    for (int i = 0; i < RowX; i++)
    {
        for (int j = 0; j < RowY; j++)
        {
            for (int k = 0; k < RowZ; k++)
            array3D[i,j,k] = new Random().Next(downBorder, topBorder);
        }
    }
    return array3D;
}

void Print3DArray(int[,,] matrix) // печатаем результат
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i,j,k] + " " + "(" + i + "," + j + "," + k + ")" + "  ");
            }
            Console.WriteLine();
        }        
    }
}

int x = ReadData("Количество строк массива по оси х : ");
int y = ReadData("Количество строк массива по оси y : ");
int z = ReadData("Количество строк массива по оси z : ");
int[,,] array3D = Fill3DArray(x,y,z,100,10);
Console.WriteLine("Ожидаемая матрица ");
Console.WriteLine("________________");
Print3DArray(array3D);