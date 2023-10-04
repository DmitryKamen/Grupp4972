// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadData(string line) // вводим число N
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int SumDigitRec(int num) // sorry не так понял задание :) и вывел сумму
{
    int sum = 0;
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return sum = num + SumDigitRec(num - 1);
    }

}

string SearchForNaturalElementsRec (int n) // Выводим натуральные числа от 1 до N
{
   return n >= 1 ? $"{n}" + "," + SearchForNaturalElementsRec(n - 1) : ""; 
}


int n = ReadData($"Введите число N : ");
Console.WriteLine("N = " + n +" " +"\"" +  SearchForNaturalElementsRec(n) +"\"");
System.Console.WriteLine($"Сумма всех натуральных чисел от 1 в до {n} равна {SumDigitRec(n)}.");