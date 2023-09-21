// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder){
    
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод показывающий сумму элементов, стоящих на нечётных позициях.
int SumOddPositions(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if( arr[i] % 2 != 0 )
        {
            sum += arr[i];
        }
        
    }
    return (sum);
}


int[] array = GenArray(10,0,9);
PrintArray(array);
int sum = SumOddPositions(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях : "+ sum);