using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseDigits
    {
        static decimal ReverseNumber(decimal n)
        {
            string number = n.ToString();
            string reversed = "";
            for (int i = 0; i < number.Length; i++)
            {
                reversed += number[number.Length - i - 1];
            }
            decimal result = decimal.Parse(reversed);
            return result;
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string number = Console.ReadLine();
            number = number.Replace(',', '.');

            decimal n = decimal.Parse(number);

            if (n < 0)
            {
                n = Math.Abs(n);
                Console.WriteLine(ReverseNumber(n) * (-1));
            }
            else
            {

                Console.WriteLine(ReverseNumber(n));
            }
        }
    }
}
