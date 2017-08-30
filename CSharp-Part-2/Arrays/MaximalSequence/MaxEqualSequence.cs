using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaxEqualSequence
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

        static int FindMaxSequence(int[] array)
        {
            int max = 0;
            int count = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (max < count)
                    {
                        max = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = CreateArray(n);

            Console.WriteLine(FindMaxSequence(array));
        }
    }
}
