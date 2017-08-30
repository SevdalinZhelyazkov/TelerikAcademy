using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class ConvertDecToBin
    {
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
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(n));
        }
    }
}
