using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSum
{
    class MaxSumConsecutive
    {
        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static int MaxSumOfConsecutive(int[] array)
        {
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    if (max < sum)
                    {
                        max = sum;
                    }

                }
                sum = 0;
            }

            return max;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = CreateArray(n);

            Console.WriteLine(MaxSumOfConsecutive(array));
        }
    }
}
