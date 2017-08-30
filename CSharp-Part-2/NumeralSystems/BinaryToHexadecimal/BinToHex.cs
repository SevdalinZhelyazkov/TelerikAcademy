using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class BinToHex
    {
        static long BinaryToDecimal(string number)
        {
            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                //int digit = number[i] == '1' ? 1 : 0;
                int digit = number[i] - '0';
                result += digit * (long)Math.Pow(2, number.Length - i - 1);
            }
            return result;
        }
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
            string number = Console.ReadLine();
            long result = BinaryToDecimal(number);
            Console.WriteLine(DecimalToHexadecimal(result));
        }
    }
}
