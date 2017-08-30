using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddPolynomial
{
    class SumPolynomials
    {
        static int[] CreateArray(int size)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            return numbers;
        }

        static int[] AddPolynomial(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] polynomial1 = CreateArray(n);
            int[] polynomial2 = CreateArray(n);

            int[] result = AddPolynomial(polynomial1, polynomial2);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
