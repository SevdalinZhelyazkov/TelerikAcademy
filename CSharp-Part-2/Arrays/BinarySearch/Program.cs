using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
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

        static int BinarySearch(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;
            Array.Sort(array);

            while (left <= right)
            {
                int middle = left + ((right - left) / 2) ;

                if (array[middle] == number) return middle;

                if (number < array[middle])
                {
                    right = middle - 1;
                }
                else if (number > array[middle])
                {
                    left = middle + 1;
                }

            }

            return -1;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = CreateArray(n);
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(array, x));
        }
    }
}
