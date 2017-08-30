using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class FillEmptySpace
    {
        static string FillString(string text)
        {
            StringBuilder filledString = new StringBuilder();
            text.Replace("\\", String.Empty);
            filledString.Append(text);
            if (text.Length < 20)
            {
                int fillLength = 20 - text.Length;
                for (int i = 0; i < fillLength; i++)
                {
                    filledString.Append('*');
                }
            }

            text = filledString.ToString();

            return text;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FillString(input));
        }
    }
}