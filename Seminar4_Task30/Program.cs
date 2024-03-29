﻿// Задача №30
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
int[] RandomArray(int count)
{
    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(0, 2);
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

int count = Prompt("Введите размер массива: ");
// int[] array = new int[count];
int[]array = RandomArray(count);
OutputArray(array);


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
using System;
int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int getRandomInt(int min, int max)
{
    int randomNum = new Random().Next(min, max);
    return randomNum;
}

int[] GenArray(int num){
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = getRandomInt(0, 2);
    }
    return array;
}

void PrintArray(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(" {0}, ", array[i]);
    }
    Console.Write("{0}]", array[array.Length - 1]);
}

PrintArray(GenArray(GetNum()));

