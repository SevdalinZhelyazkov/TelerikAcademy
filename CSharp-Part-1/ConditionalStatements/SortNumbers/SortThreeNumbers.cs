using System;
class SortThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else if (a > c)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else if (b > c)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
            else
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}