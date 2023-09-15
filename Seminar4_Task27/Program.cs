// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Принимает на вход число и выдаёт сумму цифр в числе

int SunDigitWhile(int num)
{
    int res = 0;
    while(num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}
// Вводим число
int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int result1 = SunDigitWhile(number); // Выдаёт сумму цифр в числе
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int result2 = SunDigitToString(number);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Сумма цифр в числе - " + number + " = " + result1); // Печатаем результат
PrintResult("Сумма цифр в числе - " + number + " = " + result2); // Печатаем результат

// Через стринг - Принимает на вход число и выдаёт сумму цифр в числе
int SunDigitToString(int num)
{
    int res = 0;
    string numberOfString = Convert.ToString(num);
    for(int i = 0; i < numberOfString.Length; i++)
    {
        res += Convert.ToInt32(Convert.ToString(numberOfString[i]));
    } 
    return res;
}

// вывод - метод SunDigitToString быстрее метода - SunDigitWhile

