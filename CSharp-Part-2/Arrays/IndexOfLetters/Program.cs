using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static char[] AlphabetArray()
        {
            char[] array = new char[26];
            int index = 0;
            for (int i = 97; i <= 122; i++)
            {
                array[index] = (char)i;
                index++;
            }
            return array;
        }

        static void Main(string[] args)
        {
            char[] array = AlphabetArray();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if(input[i] == array[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }

        }
    }
}
