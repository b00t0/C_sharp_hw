// Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Clear();

static char[] StringToCharArray(string str)
{
    char[] charsArray = new char[str.Length];

    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }
    return charsArray;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool Palindrome(char[] wordArray)
{
    bool palindromeCheck = false;
    for (int i = 0; i < wordArray.Length; i++)
    {
        if (wordArray[i] == wordArray[wordArray.Length - i - 1])
        {
            palindromeCheck = true;
        }
        else
        {
            palindromeCheck = false;
        }
    }
     return palindromeCheck;
}

void PrintCheck(bool result)
{
    if (result == true)
    {
        Console.WriteLine("Word is a palindrome");
    }
    else
    {
        Console.WriteLine("Word is not a palindrome");
    }
}


Console.WriteLine("Enter the string");
string str = Console.ReadLine()!;

char[] chars = StringToCharArray(str);
PrintArray(chars);

bool check = Palindrome(chars);

PrintCheck(check);

