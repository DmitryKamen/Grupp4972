// №41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int NumberOfInputs(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

int[] ArrayAssembly( int number)
{
    int count = number;
    int [] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()??"0");
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int NumbersGreaterThanZero( int[]arr )
{
    int countAboveZero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            countAboveZero++;
        }
    }
    return countAboveZero;
} 

int arraySize = NumberOfInputs("Введите размер массива: ");
int [] array = ArrayAssembly(arraySize);
PrintArray(array);
Console.WriteLine( "Колличество чисел больше нуля = "+ NumbersGreaterThanZero(array));