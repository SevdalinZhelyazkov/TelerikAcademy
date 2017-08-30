//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

class NumbersSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double p;
        for (int i = 0; i < n; i++)
        {
            p = double.Parse(Console.ReadLine());
            sum += p;
        }
        Console.WriteLine(sum);
    }
}