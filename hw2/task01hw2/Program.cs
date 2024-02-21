// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.WriteLine("Enter the integer natural number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Incorrect input");
    return;
}

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} is a multiple of 7 and 23");
}
else
{
    Console.WriteLine($"{number} is not a multiple of 7 and 23");
}
