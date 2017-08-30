//Problem 14.* Print the ASCII Table

//Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console(characters from 0 to 255).

using System;
using System.Text;
class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        for (int i = 0; i <= 255; i++)
        {
            if (!(char.IsControl((char)i))) Console.WriteLine((char)i);
        }
    }
}
