// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();


double FindMin(double[] numbers)
{
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}


double FindMax(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };

double min = FindMin(array);
double max = FindMax(array);
double diffMaxMin = max - min;

Console.WriteLine($"Maximum: {max}, minimum: {min}");
Console.WriteLine($"Difference is {diffMaxMin = max - min}");
