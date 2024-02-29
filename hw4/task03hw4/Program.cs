// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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

void ReverseArray(int[] numbers)
{
    int temp;

    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }
}

int minimum = 100;
int maximum = 999;

Console.WriteLine("Enter the array size");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = ArrayRndThreeDigit(count, minimum, maximum);
PrintArray(array);

Console.WriteLine();

ReverseArray(array);
PrintArray(array);
