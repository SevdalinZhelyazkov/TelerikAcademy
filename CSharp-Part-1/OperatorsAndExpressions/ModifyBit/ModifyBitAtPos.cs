//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v(v= 0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;
class ModifyBitAtPos
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        ulong v = ulong.Parse(Console.ReadLine());

        ulong mask = ~((ulong)1 << p);
        ulong nAndMask = mask & n;

        Console.WriteLine(nAndMask | (v << p));
    }
}
