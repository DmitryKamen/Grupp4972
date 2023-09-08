// Задание №15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekends()
{

int day = int.Parse(Console.ReadLine()??"0");

string [] dayOfWeek = new string[7];

dayOfWeek[0]="Понедельник";
dayOfWeek[1]="Вторник";
dayOfWeek[2]="Среда";
dayOfWeek[3]="Четверг";
dayOfWeek[4]="Пятница";
dayOfWeek[5]="Суббота";
dayOfWeek[6]="Воскресенье";

if ( dayOfWeek[day-1] == dayOfWeek[5] || dayOfWeek[day-1] == dayOfWeek[6] )
    {
        Console.WriteLine(day + " Да - Weekend");
        
    }
else
    {
        Console.WriteLine(day + " Нет - Not Weekend");
    }
}

Weekends();

