using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class ConvertBinToDec
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
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(number));
        }
    }
}
