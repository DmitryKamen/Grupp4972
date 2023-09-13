// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат
// точек в этой четверти (x и y).

// Вывод сообщения и вызов метода CheckingCoordinates

// string Prompt(string message)
// {
//     Console.WriteLine(message);
//     string values = Console.ReadLine()??",";
//     int quarter = Convert.ToInt32(values);

//     return CheckingCoordinates(quarter);
// }

// // Проверка четверти
// string CheckingCoordinates(int quarter)
// {
//     switch(quarter)
//     {
//         case 1: return "(X > 0 ; Y > 0)";
//         case 2: return "(X < 0 ; Y > 0)";
//         case 3: return "(X < 0 ; Y < 0)";
//         case 4: return "(X > 0 ; Y < 0)";
//         default: return "0";
//     }
// }

// Console.WriteLine(Prompt("Введите номер четверти: "));

// 2 Вариант 

int getQuarter(){
    Console.Write("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}
int quarterNum = getQuarter();


string pointsIdent(int quarterNum){
    if (quarterNum == 1) return "Возможные значения: X > 0, Y > 0";
    if (quarterNum == 2) return "Возможные значения: X < 0, Y > 0";
    if (quarterNum == 3) return "Возможные значения: X < 0, Y < 0";
    if (quarterNum == 4) return "Возможные значения: X > 0, Y < 0";
    return "Неверное значение";
}

Console.WriteLine(pointsIdent(quarterNum));



