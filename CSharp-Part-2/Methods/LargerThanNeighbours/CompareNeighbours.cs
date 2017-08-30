using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class CompareNeighbours
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

        static int LargerOfNeighbours(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = CreateArray(size);

            Console.WriteLine(LargerOfNeighbours(array));
        }
    }
}
