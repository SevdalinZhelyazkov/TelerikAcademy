using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class SumNumbers
    {
        static int[] CreateArray()
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray(); ;
            return array;
        }
        
        static List<int> SumArrays(int[] array1, int[] array2, int size1, int size2)
        {
            int maxLength = Math.Max(size1, size2);
            int minLength = Math.Min(size1, size2);
            List<int> myList = new List<int>();

            int currentSum = 0;
            int remainder = 0;
            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    currentSum = array1[i] + array2[i] + remainder;
                    remainder = 0;
                    if (currentSum >= 10)
                    {
                        remainder = 1;
                        currentSum -= 10;
                    }
                    myList.Add(currentSum);
                }
                else
                {
                    if (size1 < size2)
                    {
                        currentSum = array2[i] + remainder;
                    }
                    else
                    {
                        currentSum = array1[i] + remainder;
                    }

                    remainder = 0;

                    if (currentSum >= 10)
                    {
                        remainder = 1;
                        currentSum -= 10;
                    }

                    myList.Add(currentSum);

                    if ((i == maxLength - 1) && currentSum == 0)
                    {
                        myList.Add(1);
                    }
                }
            }
            return myList;
        }
        static void Main(string[] args)
        {
            int[] sizes = CreateArray();
            int[] array1 = CreateArray();
            int[] array2 = CreateArray();

            List<int> result = SumArrays(array1, array2, sizes[0], sizes[1]);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
