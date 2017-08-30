using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HexToBin
    {
        static long HexadecimalToDecimal(string number)
        {
            long result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else if (number[i] >= 'A' && number[i] <= 'F')
                {
                    digit = number[i] - 'A' + 10;
                }

                result += digit * (long)Math.Pow(16, number.Length - i - 1);

            }
            return result;
        }
        static string DecimalToBinary(long number)
        {
            string result = "";

            while (number > 0)
            {
                var current = number % 2;
                result = current + result;
                number /= 2;
            }

            //char[] resultAsChar = result.ToCharArray();
            //Array.Reverse(resultAsChar);
            //result = new string(resultAsChar);

            return result;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(DecimalToBinary(HexadecimalToDecimal(number)));
        }
    }
}
