// Задача № 6
// int a = 4;
// if (a % 2 == 0)
// {
//     Console.Write(a);
//     Console.WriteLine(" - ДА число четное");
// }

// int b = -3;
// if (b % 2 == 0)
// {
//     Console.Write(b);
//     Console.WriteLine(" - ДА число четное");
// }
// else
// {
//     Console.Write(b);
//     Console.WriteLine(" - НЕТ число нечетное");
// }

// int с = 7;
// if (с % 2 == 0)
// {
//     Console.Write(с);
//     Console.WriteLine(" - ДА число четное");
// }
// else
// {
//     Console.Write(с);
//     Console.WriteLine(" - НЕТ число нечетное");
// }

;
int number = int.Parse(Console.ReadLine() ?? "0");


if (number % 2 == 0)
{
    Console.Write(number);
    Console.WriteLine(" - ДА число четное");
}
else 
{
    Console.Write(number);
    Console.WriteLine(" - НЕТ число нечетное");
}
