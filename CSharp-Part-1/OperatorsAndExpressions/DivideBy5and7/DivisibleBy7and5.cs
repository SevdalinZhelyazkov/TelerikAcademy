//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided(without remainder) by 7 and 5 at the same time.

using System;
class DivisibleBy7and5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}