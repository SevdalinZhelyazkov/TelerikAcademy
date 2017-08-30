//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n(n ≤ 100) is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;
class CheckPrime
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(number);
        bool prime = true;

        while (prime && divider <= maxDivider)
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        
        if (prime && number >= 2)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}