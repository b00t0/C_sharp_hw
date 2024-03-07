// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


Console.Clear();

int[] SumRows(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumRows[i] = sum;
    }
    return sumRows;
}

int MinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            minIndex = i;
        }
    }
    return minIndex;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i], 10}");
    }
}




int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};


int[] newArray = SumRows(numbers);
PrintArray(newArray);

Console.WriteLine();

Console.WriteLine(MinIndex(newArray));
