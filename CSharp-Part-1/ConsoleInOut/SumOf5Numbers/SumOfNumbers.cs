//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers(given in a single line, separated by a space), calculates and prints their sum.

using System;
class SumOfNumbers
{
    static void Main()
    {
        int sum = 0;
        int num;
        for (int i = 0; i < 5; i++)
        {
            num = int.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
