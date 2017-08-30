using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NOT IMPLEMENTED !!!!!!!!!!!

namespace RemoveElementSort
{
    class Program
    {
        static List<int> CreateList(int size)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < size; i++)
            {
                myList.Add(int.Parse(Console.ReadLine()));
            }
            return myList;
        }
        static int ElementsRemoveToSort(List<int> myList)
        {
            int count = 0;

            for (int i = 0; i < myList.Count - 1; i++)
            {
                if (myList[i] > myList[i + 1])
                {
                    if (i <= myList.Count)
                    {
                        if ((myList[i - 1] < myList[i + 1] && myList[i + 1] < myList[i + 2]) || i == 0)
                        {
                            myList.Remove(myList[i]);
                            count++;
                        }
                        else
                        {
                            myList.Remove(myList[i + 1]);
                            count++;
                        }
                    }
                    else
                    {
                        myList.Remove(myList[i + 1]);
                        count++;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<int> myList = CreateList(size);
            Console.WriteLine(ElementsRemoveToSort(myList));
        }
    }
}
