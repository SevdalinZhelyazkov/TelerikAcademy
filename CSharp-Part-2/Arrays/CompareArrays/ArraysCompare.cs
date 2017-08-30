using System;

namespace CompareArrays
{
    class ArraysCompare
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

        static string EqualLengthArrayCompare(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i]) return "Not equal";
            }

            return "Equal";
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = CreateArray(n);
            int[] array2 = CreateArray(n);

            Console.WriteLine(EqualLengthArrayCompare(array1, array2));
        }
    }
}
