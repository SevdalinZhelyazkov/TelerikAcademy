using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MaxKsum
{
    class MaximumKsum
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

        static int FindMaxSum(int[] array, int k)
        {
            int maxSum = 0;
            int index = 0;

            for (int i = 0; i < k; i++)
            {
                int maxElement = int.MinValue;
                for (int j = 0; j < array.Length; j++)
                {
                    if (maxElement < array[j])
                    {
                        maxElement = array[j];
                        index = j;
                    }
                }
                maxSum += maxElement;
                array[index] = int.MinValue;
            }

            return maxSum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = CreateArray(n);

            Console.WriteLine(FindMaxSum(array, k));
        }
    }
}
