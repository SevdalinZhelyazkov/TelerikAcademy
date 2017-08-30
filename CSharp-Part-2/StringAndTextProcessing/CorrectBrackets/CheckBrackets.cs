using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CheckBrackets
    {
        static string ValidateBrackets(string inputString)
        {
            bool isValid = true;
            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];
                if(currentChar == '(')
                {
                    count++;
                }
                else if(currentChar == ')')
                {
                    count--;
                }

                if(count < 0)
                {
                    isValid = false;
                    break;
                }
            }

            if (count != 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                return "Correct";
            }
            else
            {
                return "Incorrect";
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ValidateBrackets(input));
        }
    }
}
