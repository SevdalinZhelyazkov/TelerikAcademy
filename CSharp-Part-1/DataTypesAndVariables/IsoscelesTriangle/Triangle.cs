//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

using System;
using System.Text;

class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char copyright = '\xA9';
        Console.WriteLine("   " + copyright + "\n");
        Console.WriteLine("  " + copyright + " " + copyright + "\n");
        Console.WriteLine(" " + copyright + "   " + copyright + "\n");
        Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright + "\n");


        // Implementation with Loops
        for (int row = 1; row <= 4; row++)
        {
            for (int space = 3; space >= row; space--)
            {
                Console.Write(" ");
            }
            for (int col = 1; col <= row; col++)
            {
                if (col == 1 || col % 2 == 0 || row % 2 == 0)
                {
                    Console.Write(copyright);
                    Console.Write(" ");
                }
                if (row == 3 && col == 1)
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}