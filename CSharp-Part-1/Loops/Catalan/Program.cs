using System;
using System.Numerics;

namespace Catalan
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 2 * n;
            int second = (n + 1);
            BigInteger factFirst = 1;
            BigInteger factSecond = 1;
            BigInteger factN = 1;
            int i = n;

            while (first > 0)
            {
                factFirst *= first;
                first--;
            }
            while (i > 0)
            {
                factSecond *= second;
                factN *= i;
                second--;
                i--;
            }
            Console.WriteLine(factFirst / (factSecond * factN));
        }
    }
}
