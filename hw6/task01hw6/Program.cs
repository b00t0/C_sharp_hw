//  Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


string GetStringFromCharMatrix(char[,] matrix)
{
    string str = string.Empty;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str += matrix[i, j];
        }
    }
    return str;
}

char[,] charsMatrix = {
    { 'a', 'b', 'c' },
    { 'd', 'e', 'f' }
};

Console.WriteLine(GetStringFromCharMatrix(charsMatrix));