// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

Console.Clear();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SwapFirstLastRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        SwapItems(array, i);
    }

    return array;
}

void SwapItems(int[,] array, int i)
{
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}


int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

PrintArray(SwapFirstLastRows(numbers));
