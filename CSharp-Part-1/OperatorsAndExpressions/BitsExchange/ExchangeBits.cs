//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        long n = long.Parse(Console.ReadLine());

        long lastBits = ((7 << 3) & n) << 21; // Get bits at position 3, 4 and 5
        long firstBits = ((7 << 24) & n) >> 21; // Get bits at position 24, 25 and 26

        long exchangeLast = (~(7 << 3) & n) | firstBits; // Set bits 3, 4 and 5 to 0, and place firstBits there
        long result = (~(7 << 24) & exchangeLast) | lastBits; // Set bits 24, 25 and 26 to 0, and place lastBits there
        Console.WriteLine(result);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(64, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0'));
    }
}