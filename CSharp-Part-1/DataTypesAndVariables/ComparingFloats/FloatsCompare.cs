//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers(double) with precision eps = 0.000001.

using System;
class FloatsCompare
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (Math.Abs(a - b) < 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}