// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

Console.Clear();

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

int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};

Console.WriteLine(CountEvenNumbers(array));