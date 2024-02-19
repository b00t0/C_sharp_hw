// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.


Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 2)
{
    Console.WriteLine("Incorrect input");
    return;
}

int count = 0;
while (count < number - 1)
{
    count = count + 2;
    Console.Write($"{count} ");
}
