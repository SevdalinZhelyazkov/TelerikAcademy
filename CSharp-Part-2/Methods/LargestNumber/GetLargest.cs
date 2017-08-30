using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class GetLargest
    {
        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int comparison = GetMax(numbers[0], numbers[1]);
            Console.WriteLine((comparison > numbers[2]) ? comparison : numbers[2]);
        }
    }
}
