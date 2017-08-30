//Problem 7. Point in a Circle

//Write an expression that checks if given point(x, y) is inside a circle K({ 0, 0}, 2).

using System;
class InsideCircle
{
    static void Main()
    {
        // Read data from user
        Console.Write("Enter Coord X for circle: ");
        float circleX = float.Parse(Console.ReadLine());
        Console.Write("Enter Coord Y for circle: ");
        float circleY = float.Parse(Console.ReadLine());
        Console.Write("Enter Radius for circle: ");
        float r = float.Parse(Console.ReadLine());
        Console.Write("Enter number for X: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter number for Y: ");
        float y = float.Parse(Console.ReadLine());

        // Calculation
        Console.WriteLine((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) < r * r);
    }
}