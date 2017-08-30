//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class CheckThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()) / 100;
        if (number % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", number % 10);
        }
    }
}