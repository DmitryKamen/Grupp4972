// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string [] CreateStringArray ()
{
    string [] ArrSt;
    int count;
    string s;
    string [] ArrSt2;
    Console.WriteLine("Enter strings");
    count = 0;
    ArrSt = new string [count];
    do
    {
        s = Console.ReadLine();
        if ( s != "" )
        {
            count++;
            ArrSt2 = new string [count];
            for ( int i = 0; i < ArrSt2.Length - 1; i++ )
                ArrSt2[i] = ArrSt[i];
            ArrSt2[count - 1] = s;
            ArrSt = ArrSt2;
        }
    } while (s != "");
    return ArrSt;
}


 string[] MethodRes (string[] arrSt)
{
    int count = 0;
    for ( int i = 0; i < arrSt.Length; i++ )
    {
        if (arrSt[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arrStRes = new string [count];
    int index = 0;
    for ( int i = 0; i < arrSt.Length; i++ )
    {
        if (arrSt[i].Length <= 3)
        {
            arrStRes[index] = arrSt[i];
            index++;
        }
    }
    return arrStRes;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

string [] FirstArray = CreateStringArray ();
string [] FinalArray = MethodRes(FirstArray);
PrintArray(FirstArray);
PrintArray(FinalArray);
