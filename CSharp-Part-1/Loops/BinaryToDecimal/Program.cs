using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            long number = 0;

            for (int i = 0; i < 64; i++)
            {
                if (n % 10 == 1)
                {
                    number += (long)Math.Pow(2, i);
                }
                n /= 10;
            }
            Console.WriteLine(number);
        }
    }
}
