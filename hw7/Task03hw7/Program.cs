// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
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
        Console.Write($"{array[i],5}");
    }
}

void PrintReverseArray(int[] array, int i)
{
    if (i < 0) return;
    Console.Write($"{array[i],5}");
    PrintReverseArray(array, i - 1);
}

int[] array = CreateArrayRndInt(10, 1, 100);
Console.WriteLine("Initial array");
PrintArray(array);

Console.WriteLine();

Console.WriteLine("Reverse array");
PrintReverseArray(array, array.Length - 1);

