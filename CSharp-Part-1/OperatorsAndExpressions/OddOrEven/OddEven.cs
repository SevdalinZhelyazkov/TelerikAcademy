//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;
class OddEven
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());

        while (userInput  < -30 || userInput > 30)
        {
            userInput = int.Parse(Console.ReadLine());
        }

        if (userInput % 2 == 0)
        {
            Console.WriteLine("even " + userInput);
        }
        else
        {
            Console.WriteLine("odd " + userInput);
        }
    }
}
