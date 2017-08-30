using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInText
{
    class CountSubstring
    {
        static int SubstringCount(string text, string pattern)
        {
            int count = 0, index = -1;

            pattern = pattern.ToLower();
            text = text.ToLower();

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index < 0)
                {
                    break;
                }
                count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            string inputSubString = Console.ReadLine();
            string inputString = Console.ReadLine();

            Console.WriteLine(SubstringCount(inputString, inputSubString));
        }
    }
}
