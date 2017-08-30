using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class CountAppearance
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
        static int CountMatch(int[] array, int x)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x == array[i])
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
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(CountMatch(array, x));
        }
    }
}
