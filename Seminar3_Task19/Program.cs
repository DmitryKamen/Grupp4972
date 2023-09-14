using System;

public class Answer
{

    static bool IsPalindrome(int number)
    {
        if (number > 99999 || number < 10000)
        {
            Console.WriteLine(number + " - Число не пяти значное");
            return false;
        }
        else
        {
            string num = Convert.ToString(number);
            if (num[0] == num[4] && num[1] == num[3])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}