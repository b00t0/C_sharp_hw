// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


Console.Clear();

Console.WriteLine("Enter the string");
string str = Console.ReadLine()!;

string lowers =str.ToLower();
Console.WriteLine(lowers);
