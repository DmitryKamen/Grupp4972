﻿// Задание № 8

// int N1 = 1;
// while ( N1 < 6 )
// {
//     if( N1 % 2 == 0)
//     {
//         Console.WriteLine(N1);
//     }
// N1 = N1 + 1;
// }
// Console.WriteLine("Чётные числа");

// int N2 = 1;
// while ( N2 < 9 )
// {
//     if( N2 % 2 == 0)
//     {
//         Console.WriteLine(N2);
//     }
// N2 = N2 + 1;
// }
// Console.Write("Чётные числа");

int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int count = 1;
while ( count < N + 1 )
{
   if( count % 2 == 0)
    {
        Console.WriteLine(count);
    }
//count = count + 1;
count++;
}
 Console.WriteLine("Чётные числа");