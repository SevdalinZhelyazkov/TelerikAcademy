using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class ArraySorting
    {
        static int[] CreateArray(int size)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            if (numbers.Length != size)
            {
                Console.WriteLine("Invalid array size!");
            }
            return numbers;
        }

        static int FindMax(int[] array, int position)
        {
            int max = array[position];
            int index = 0;
            for (int i = position; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            array[index] = int.MinValue;
            return max;
        }

        static int[] ArraySort(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sortedArray[arr.Length - i - 1] = FindMax(arr, 0);
            }
            return sortedArray;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] unsortedArray = CreateArray(n);
            int[] sortedArray = ArraySort(unsortedArray);
            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
