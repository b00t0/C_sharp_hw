﻿// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);


// return Math.Max (Math.Max(a, b), c);