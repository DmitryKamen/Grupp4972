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

// ВАРИАНТ 2 
// решение задачи без использования массива

// Приглашение в консоли ввести число
Console.WriteLine("Введите положительное число");

// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int num = int.Parse(Console.ReadLine() ?? "0");

// вычисляем разрядность введенного числа c помощью десятичного логарифма
double digit = Math.Log10(num);
// Конвертирую double -> int и отбрасываю дробную часть
digit = (int)digit;

// проверяем введенное число,  оно должно быть 3х значное или больше
if (digit > 1)
{
    // устанавливаем счетчик
    int count = 1;
    // объявляем переменную
    int res = num;
    while (count < digit - 1)
    {
        // отбрасываем число до 3 знаков
        res = res/10;
        count ++;
    }
    // Выводим последнюю цифру числа
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}

else
{
    // Выводим результат если введено двузначное или однозначное число
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}
