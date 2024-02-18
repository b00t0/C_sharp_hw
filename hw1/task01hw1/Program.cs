// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("числа равны");
}
else
{
    if (num1 > num2)
    {
        Console.WriteLine("первое число больше");
    }
    else
    {
        Console.WriteLine("второе число больше");
    }
}
