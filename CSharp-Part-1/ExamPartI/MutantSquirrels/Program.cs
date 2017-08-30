using System;
using System.Numerics;

namespace MutantSquirrels
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong t = ulong.Parse(Console.ReadLine()); // number of trees
            ushort b = ushort.Parse(Console.ReadLine()); // number of branches on tree
            ushort s = ushort.Parse(Console.ReadLine()); // number of squirrels on each branch
            byte n = byte.Parse(Console.ReadLine()); // average number of tails for each squirrel

            double totalSquirrels = t * b * s;
            double totalTails = totalSquirrels * n;
            double result = (totalTails / 7.0);

            if (totalTails % 2 == 0)
            {
                Console.WriteLine("{0:F3}", totalTails * 376439);
            }
            else
            {
                Console.WriteLine("{0:F3}", result);
            }

        }
    }
}
