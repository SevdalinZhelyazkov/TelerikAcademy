using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class CalculateIntegers
    {
        static int[] CreateArray()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            return numbers;
        }
        static string Calculate(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            double sum = 0;
            long product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            double average = sum / numbers.Length;

            string result = string.Format("{0}\n{1}\n{2:F2}\n{3}\n{4}", min, max, average, sum, product);

            return result;
        }
        static void Main(string[] args)
        {
            int[] numbers = CreateArray();
            Console.WriteLine(Calculate(numbers));
        }
    }
}
