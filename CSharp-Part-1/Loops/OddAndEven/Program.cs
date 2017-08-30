using System;

namespace OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long productOdd = 1, productEven = 1;
            string numbersInput = Console.ReadLine();
            string[] numbers = numbersInput.Split(' ');

            for (int i = 0; i < n; i++)
            {
                int num;
                if (int.TryParse(numbers[i], out num))
                {
                    if (i % 2 == 0)
                    {
                        productOdd *= num;
                    }
                    else
                    {
                        productEven *= num;
                    }
                }
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes " + productOdd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }

        }
    }
}
