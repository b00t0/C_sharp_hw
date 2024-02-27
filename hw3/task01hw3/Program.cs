// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,90].

Console.Clear();

int CountItemsRange(int[] numbers, int minRange, int maxRange)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= minRange && numbers[i] <= maxRange)
        {
            count++;
        }
    }
    return count;
}


int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };

Console.WriteLine(CountItemsRange(array, 10, 90));