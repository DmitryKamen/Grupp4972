﻿// Задача №28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Ввод числа из консоли
int readData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод числа в консоль
void PrintResult(string mes)
{
    Console.WriteLine(mes);
}


long FactorialNum(int num)
{
    long fact=1;

    for(int i=2; i<=num; i++)
    {
        fact*=i;
    }
    return fact;
}

int enterNum=readData("Введите число: ");
long result=FactorialNum(enterNum);

PrintResult($"Произведение чисел от 1 до {enterNum} = {result}");


// 2 variant

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24 5 -> 120

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Считаем цифры
long CountFact(int num)
{
    long fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int num = ReadData("Введите целое число: ");
long fact = CountFact(num);
PrintResult("Факториал числа " + num + " равен " + fact);