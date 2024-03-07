// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.


Console.Clear();

static int FindElementByPosition(int[,] array, int x, int y)
{
    int element = array[x - 1, y - 1];
    return element;
}

static bool ValidatePosition(int[,] array, int x, int y)
{
    bool position;
    if (x <= array.GetLength(0) && y <= array.GetLength(1))
    {
        position = true;
    }
    else
    {
        position = false;
    }
    return position;
}

static void PrintResult(int[,] numbers, int x, int y)
{
    if (ValidatePosition(numbers, x, y) == true)
    {
        Console.Write($"{numbers[x - 1, y - 1]}");
    }
    else
    {
        Console.Write("Позиция по колонкам выходит за пределы массива");
    }

}


int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

// int x = 2;
// int y = 2;

bool check = ValidatePosition(numbers, 5, 5);
Console.WriteLine(check);

Console.WriteLine();

PrintResult(numbers, 5, 5);


// int result = FindElementByPosition(numbers, 5, 5);
// Console.WriteLine(result);
