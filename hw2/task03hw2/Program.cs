// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.WriteLine("Enter the integer natural two-digit number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 || number > 99) {
        Console.WriteLine("Incorrect input");
        return;
    }
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit) {
        Console.WriteLine($"{firstDigit}");
    }
    else {
Console.WriteLine($"{secondDigit}");
    }
    