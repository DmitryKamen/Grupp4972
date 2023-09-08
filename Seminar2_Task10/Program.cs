// Задание №10 Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine( "Ввведенное число - " + number);
char[] digitChar = number.ToString().ToCharArray();
Console.WriteLine(number > 99 && number < 1000 ? digitChar[1] + " - Вторая цифра числа" : 
"число не трехзначное");


