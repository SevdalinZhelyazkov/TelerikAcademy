//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
using System.Numerics;
class CalculateFibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger p = 1; // serves as n-1
        BigInteger j = 0; // serves as n-2
        BigInteger res;
        for (int i = 0; i < n; i++)
        {
            switch (i)
            {
                case 0:
                    Console.Write("0");
                    if (i != n - 1) Console.Write(", ");
                    break;
                case 1:
                    Console.Write("1");
                    if (i != n - 1) Console.Write(", ");
                    break;
                default:
                    res = p + j;
                    j = p;
                    p = res;
                    Console.Write(res);
                    if (i != n - 1) Console.Write(", ");
                    break;
            }
        }
        Console.WriteLine();
    }
}