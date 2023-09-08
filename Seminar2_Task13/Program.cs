// Задача №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine( "Ввведенное число - " + number);
char[] digitChar = number.ToString().ToCharArray();
Console.WriteLine( number < 100  ? "третий цифры нет" :
digitChar[2] + " - третья цифра числа");
