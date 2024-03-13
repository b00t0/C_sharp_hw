// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


Console.Clear();

int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m = m + 1;
    }
    if (m == 0)
    {
        return Ackermann(n-1, 1);
    }
        return Ackermann(n - 1, Ackermann (n, m - 1));
}


Console.WriteLine("Enter the non-negative integer number M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the non-negative integer number N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Incorrect input. Need to enter the non-negative numbers");
    return;
}

Console.WriteLine($"Result of Ackermann function is {Ackermann(numberM, numberN)}");
