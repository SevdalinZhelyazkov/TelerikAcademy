using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int row = 0; row < array.GetLength(1); row++)
            {
                for (int col = 0; col < array.GetLength(0); col++)
                {
                    Console.Write("{0,-2}", array[col, row]);
                }
                Console.WriteLine();
            }
        }
    }
}
