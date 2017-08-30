//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point(x, y) if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).

using System;
class InCircleOutRect
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r;
        bool inRectangle = (y <= 1 && y >= -1) && (x > -1 && x < 5);
        string result;
        result = inCircle ? "inside circle" : "outside circle";
        result += inRectangle ? " inside rectangle" : " outside rectangle";
        Console.WriteLine(result);
    }
}