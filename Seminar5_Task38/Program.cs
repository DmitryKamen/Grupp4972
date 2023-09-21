// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

//Заполняем одномерный массив вещественными числами до десятых от нуля
double[] GenArray(int num, int lowBorder, int highBorder)
{
    
    double[] array = new double[num];
    
    for (int i = 0; i < num; i++)
    {
       array[i] = new Random().Next(lowBorder, highBorder+1) + Math.Round(new Random().NextDouble(),1);
    }

    return array;
}

// Печатаем результат
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод показывающий разницу между максимальным 
// и минимальным элементами массива.
double DifferenceMaxMin(double[] arr)
{
    double dif;
    double max = 0;
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if( arr[i] > max )
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }    
    }
    dif = max - min;
    return (dif);  
}

double[] array = GenArray(5,0,9);
PrintArray(array);
double difference = DifferenceMaxMin(array);
Console.WriteLine( "Разница между максимальным и минимальным элементами массива = " + difference );