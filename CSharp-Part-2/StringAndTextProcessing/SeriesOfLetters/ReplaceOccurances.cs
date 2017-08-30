using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class ReplaceOccurances
    {
        static string RemoveIdentical(string text)
        {
            StringBuilder result = new StringBuilder();

            int newChar = 1;

            result.Append(text[0]);

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    newChar = 0;
                }
                else
                {
                    newChar = 1;
                }
                if (newChar == 1) result.Append(text[i + 1]);
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(RemoveIdentical(input));
        }
    }
}
