// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] ArrayRndThreeDigit(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountEvenNumbers(int[] numbers)
{
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
return count;
}

int minimum = 100;
int maximum = 999;

Console.WriteLine("Enter the array size");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = ArrayRndThreeDigit(count, minimum, maximum);
PrintArray(array);

Console.WriteLine();

Console.WriteLine(CountEvenNumbers(array));
