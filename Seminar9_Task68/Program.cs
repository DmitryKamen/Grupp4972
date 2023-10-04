// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string line) // вводим число N
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int AkkermanFunctionRec(int m, int n) // функция Аккермана
{
    if (m == 0)
        return n + 1;
    else
      
    if (n == 0) 
        
        return AkkermanFunctionRec(m - 1, 1);
    else
        return AkkermanFunctionRec(m - 1, AkkermanFunctionRec (m, n - 1));
        
    
  
}

int m = ReadData($"Введите число M : ");
int n = ReadData($"Введите число N : ");

Console.WriteLine($"A({m},{n}) равна {AkkermanFunctionRec(m,n)}.");