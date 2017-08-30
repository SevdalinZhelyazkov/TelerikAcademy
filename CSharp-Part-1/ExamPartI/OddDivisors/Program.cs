using System;

namespace OddDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            int sumAll = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        if (i % j == 0)
                        {
                            sum += j;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
