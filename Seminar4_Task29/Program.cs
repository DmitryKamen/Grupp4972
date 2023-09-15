﻿// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// Заполняет массив случайными цифрами
int[] RandomArray(int count)
{

    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(0, 9);
    return randNums;
}
// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ",");
    Console.Write(array[array.Length - 1] + "]");
}

int count = 8; // Prompt("Введите размер массива: ");
// int[] array = new int[count];
int[]array = RandomArray(count);
OutputArray(array);
