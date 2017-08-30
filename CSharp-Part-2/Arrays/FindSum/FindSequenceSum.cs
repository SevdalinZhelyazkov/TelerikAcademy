using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSum
{
    class FindSequenceSum
    {
        static string FindSum(int[] array, int sum)
        {
            int currentSum = 0;
            int iIndex = 0;
            int jIndex = 0;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum == sum)
                    {
                        iIndex = i;
                        jIndex = j;
                        isFound = true;
                        break;
                    }
                }
                currentSum = 0;
                if (isFound) break;
            }

            // Print the sequence from the array
            string result = "";
            if (isFound)
            {
                for (int i = iIndex; i <= jIndex; i++)
                {
                    result += array[i] + " ";
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSum(numbers, sum));
        }
    }
}
