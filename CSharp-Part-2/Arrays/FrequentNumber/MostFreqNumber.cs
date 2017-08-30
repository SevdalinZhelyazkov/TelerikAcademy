using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class MostFreqNumber
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

        static string FindMostFrequent(int[] array)
        {
            int count = 1;
            int max = 0;
            int number = 0;
            int index = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int current = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (current == array[j])
                    {
                        count++;
                        index = j;
                    }
                }
                if (max < count)
                {
                    number = array[index];
                    max = count;
                }
                count = 1;
            }
            return string.Format("{0} ({1} times)", number, max);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = CreateArray(n);

            Console.WriteLine(FindMostFrequent(array));
        }
    }
}
