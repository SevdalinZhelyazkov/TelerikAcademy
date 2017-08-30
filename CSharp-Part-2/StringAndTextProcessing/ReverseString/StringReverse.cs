using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class StringReverse
    {
        static string Reverse(string inputString)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversed.Append(inputString[i]);
            }
            string reversedString = reversed.ToString();
            return reversedString;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));
        }
    }
}
