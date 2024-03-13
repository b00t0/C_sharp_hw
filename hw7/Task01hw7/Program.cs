// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

void NaturalNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        Console.Write($"{secondNumber}");
    }
    else if (firstNumber < secondNumber)
    {
        NaturalNumbers(firstNumber, secondNumber - 1);
        Console.Write($", {secondNumber}");
    }
    else
    {
        Console.Write($"{firstNumber}, ");
        NaturalNumbers(firstNumber - 1, secondNumber);
    }
}

Console.WriteLine("Enter the natural integer number M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the natural integer number N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM <= 0 || numberN <= 0)
{
    Console.WriteLine("Incorrect input. Need to enter the natural numbers");
    return;
}

NaturalNumbers(numberM, numberN);
