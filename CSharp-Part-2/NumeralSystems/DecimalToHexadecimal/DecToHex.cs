using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecToHex
    {
        static string DecimalToHexadecimal(long decimalNumber)
        {
            string hexNumber = "";

            while (decimalNumber > 0)
            {
                long digit = decimalNumber % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hexNumber = (char)(digit + '0') + hexNumber;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hexNumber = (char)(digit - 10 + 'A') + hexNumber;
                }
                decimalNumber /= 16;
            }

            return hexNumber;
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToHexadecimal(n));
        }
    }
}
