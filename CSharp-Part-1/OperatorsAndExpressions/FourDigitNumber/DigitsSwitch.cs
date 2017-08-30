//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
//Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba(in our example 1102).
//Puts the last digit in the first position: dabc(in our example 1201).
//Exchanges the second and the third digits: acbd(in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
class DigitsSwitch
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        short a, b, c, d;
        a = (short)(number / 1000);
        b = (short)((number / 100) % 10);
        c = (short)((number / 10) % 10);
        d = (short)(number % 10);

        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0:0000}", d * 1000 + c * 100 + b * 10 + a);
        Console.WriteLine("{0:0000}", d * 1000 + a * 100 + b * 10 + c);
        Console.WriteLine("{0:0000}", a * 1000 + c * 100 + b * 10 + d);
    }
}