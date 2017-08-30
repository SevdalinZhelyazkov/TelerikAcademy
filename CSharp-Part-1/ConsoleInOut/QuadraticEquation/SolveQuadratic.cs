﻿//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).

using System;
using System.Globalization;
using System.Threading;

class SolveQuadratic
{
    private static CultureInfo cultureinfo;

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());


        double discriminant = b * b - 4 * a * c;

        if (discriminant >= 0)
        {
            if (discriminant == 0)
            {
                Console.WriteLine("{0:F2}", -b / (2 * a));
            }
            else
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                if (x1 > x2)
                {
                    Console.WriteLine("{0:F2}", x2);
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    Console.WriteLine("{0:F2}", x1);
                    Console.WriteLine("{0:F2}", x2);
                }
            }
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}