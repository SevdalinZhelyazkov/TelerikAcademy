using System;
class PrintBorder
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n + 1; i++)
        {
            if (i != n)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = n * 2; j > n - i + 2; j--)
                {
                    if (i != 0)
                    {
                        Console.Write(".");
                    }
                    else
                    { 
                        Console.Write("*");
                    }
                }
                Console.Write("*");
            }
            else
            {
                for (int j = 0; j < n * 2; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}