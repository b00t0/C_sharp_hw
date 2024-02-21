// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Enter the x coordinates");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y coordinates");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("The first quarter of the Cartesian system coordinates");
    return;
}

if (x < 0 && y > 0)
{
    Console.WriteLine("The second quarter of the Cartesian system coordinates");
    return;
}

if (x < 0 && y < 0)
{
    Console.WriteLine("The third quarter of the Cartesian system coordinates");
    return;
}

if (x > 0 && y < 0)
{
    Console.WriteLine("The fourth quarter of the Cartesian system coordinates");
    return;
}
