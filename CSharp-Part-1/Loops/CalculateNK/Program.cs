using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factK = 1;
        int bigger = (n > k) ? n : k;

        for (int i = 1; i <= bigger; i++)
        {
            if (k >= i)
            {
                factK *= i;
            }

            if (n >= i)
            {
                factN *= i;
            }
        }
        Console.WriteLine(factN / factK);
    }
}