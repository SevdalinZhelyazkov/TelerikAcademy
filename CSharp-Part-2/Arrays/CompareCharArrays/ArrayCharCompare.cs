using System;

namespace _03.CompareCharArrays
{
    class ArrayCharCompare
    {
        static string CharArrayComparer(char[] array1, char[] array2)
        {
            int minLength = Math.Min(array1.Length, array2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (array1[i] > array2[i])
                {
                    return ">";
                }
                if (array1[i] < array2[i])
                {
                    return "<";
                }
            }

            if (array1.Length > array2.Length)
            {
                return ">";
            }
            else if (array1.Length < array2.Length)
            {
                return "<";
            }
            else
            {
                return "=";
            }
        }

        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();

            Console.WriteLine(CharArrayComparer(array1, array2));
        }
    }
}