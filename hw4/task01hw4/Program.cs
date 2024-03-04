// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа 
// с консоли. Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

Console.Clear();

static int DigitSum(int currentNum)
{
    int digitSum = 0;
    while (currentNum > 0)
    {
        digitSum += currentNum % 10;
        currentNum /= 10;
    }
    return digitSum;
}


while (true)
{
    Console.WriteLine("Enter the integer number");
    string stopWord = Console.ReadLine()!;

    if (stopWord == "q")
    {
        Console.WriteLine("Stop word");
        break;
    }

    if (int.TryParse(stopWord, out int number))
    {
        // int sum = 0;
        int sum = DigitSum(number);
        // while (number > 0)
        // {
        //     sum += number % 10;
        //     number /= 10;
        // }
        Console.WriteLine($"Sum of the numbers is {sum}");

        if (sum % 2 == 0)
        {
            Console.WriteLine("The digitSum is even");
            break;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input");
    }
}

