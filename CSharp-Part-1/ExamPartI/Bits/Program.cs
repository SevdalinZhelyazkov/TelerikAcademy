using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string pStr = Convert.ToString(p, 2);

            for (int i = 0; i < m; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string nStr = Convert.ToString(n, 2);
                for (int pos = 0; pos <= nStr.Length - pStr.Length; pos++)
                {
                    bool match = true;
                    for (int j = 0; j < pStr.Length; j++)
                    {
                        var posInN = pos + j;
                        var posInP = j;

                        int bitInN = (n & (1 << posInN)) >> posInN;
                        int bitInP = (p & (1 << posInP)) >> posInP;

                        if (bitInN != bitInP)
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        for (int k = 0; k < pStr.Length; k++)
                        {
                            n = n & ~((1) << (pos + k));
                        }
                    }

                    //int bits = p << pos;
                    //if ((n | bits) == n)
                    //{
                    //    n = n & (~bits);
                    //    pos += pStr.Length - 1;
                    //}
                }
                Console.WriteLine(n);

            }
        }
    }
}
