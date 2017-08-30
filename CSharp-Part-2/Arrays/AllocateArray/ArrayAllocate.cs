using System;

namespace AllocateArray
{
    class ArrayAllocate
    {
        static int[] CreateArray(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i * 5;
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = CreateArray(n);
            PrintArray(array);
        }
    }
}
