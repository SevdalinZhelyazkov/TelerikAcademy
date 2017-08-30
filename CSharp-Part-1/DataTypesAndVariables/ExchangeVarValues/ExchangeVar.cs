//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;
class ExchangeVar
{
    static void Main()
    {
        int a, b, temp;

        Console.Write("Input first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("\nNormal:\na = " + a + " and b = " + b);

        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("\nReversed:\na = " + a + " and b = " + b + "\n");
    }
}
