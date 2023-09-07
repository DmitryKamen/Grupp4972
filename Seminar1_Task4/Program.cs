// Задача № 4
// int a1 = 2;
// int b1 = 3;
// int c1 = 7;
// int max1 = a1;
// if (b1 > max1)
// {
//     max1 = b1;
// }
// if (c1 > max1)
// {
//     max1 = c1;
// }
// Console.Write("max1 = ");
// Console.WriteLine(max1);

// int a2 = 44;
// int b2 = 5;
// int c2 = 78;
// int max2 = a2;
// if (b2 > max2)
// {
//     max2 = b2;
// }
// if (c2 > max2)
// {
//     max2 = c2;
// }
// Console.Write("max2 = ");
// Console.WriteLine(max2);

// int a3 = 22;
// int b3 = 3;
// int c3 = 9;
// int max3 = a3;
// if (b3 > max3)
// {
//     max3 = b3;
// }
// if (c3 > max3)
// {
//     max3 = c3;
// }
// Console.Write("max3 = ");
// Console.WriteLine(max3);

int first = int.Parse(Console.ReadLine() ?? "0");

int second = int.Parse(Console.ReadLine() ?? "0");

int third = int.Parse(Console.ReadLine() ?? "0");

int max = first;
if (second > max)
{
    max = second;
}
if (third > max)
{
    max = third;
}
Console.Write("max = ");
Console.WriteLine(max);