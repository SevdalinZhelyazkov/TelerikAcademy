using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNK = 1;


        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            if (k >= i)
            {
                factK *= i;
            }
        }

        for (int i = 1; i <= (n - k); i++)
        {
            factNK *= i;
        }

        Console.WriteLine(factN / (factK * factNK));
    }
}