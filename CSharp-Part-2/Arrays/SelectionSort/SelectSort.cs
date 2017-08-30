using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectSort
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

        static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int jMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[jMin])
                    {
                        jMin = j;
                    }
                }

                if (jMin != i)
                {
                    int temp = array[i];
                    array[i] = array[jMin];
                    array[jMin] = temp;
                }
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = CreateArray(n);

            SelectionSort(array);
            PrintArray(array); // can be on separate lines, because array is passed by reference
        }
    }
}
