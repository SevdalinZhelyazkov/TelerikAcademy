using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToUnicode
{
    class UnicodeChar
    {
        static string StringToUnicode(string text)
        {
            char[] textChar = text.ToCharArray();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < textChar.Length; i++)
            {
                result.Append("\\u" + ((int)textChar[i]).ToString("X4"));
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string clean = input.Trim(' ', '\n', '\t');
            Console.WriteLine(StringToUnicode(clean));
        }
    }
}
