//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class PrintPerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string radiusIn = Console.ReadLine();
        radiusIn = radiusIn.Replace(',', '.');
        double radius = double.Parse(radiusIn);
        
        Console.WriteLine("{0:F2} {1:F2}", 2 * radius * Math.PI, radius * radius * Math.PI);
    }
}
