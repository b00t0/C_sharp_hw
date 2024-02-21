// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Enter the integer natural number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Incorrect input");
    return;
}

int n = number % 10;
int m = number / 10;

while (m > 0) {
    n = n * 10 + m % 10;
    m = m / 10;
    
}
int digit = 0;
while (n > 10) {
    digit = n % 10;
    Console.Write($"{digit}, ");
    n = n / 10;
}
digit = n % 10;
Console.Write($"{digit}");
