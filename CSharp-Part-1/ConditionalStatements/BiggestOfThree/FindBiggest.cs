using System;
class FindBiggest
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggest;

        if (a > b)
        {
            if (a > c)
            {
                biggest = a;
            }
            else
            {
                biggest = c;
            }
        }
        else
        {
            if (b > c)
            {
                biggest = b;
            }
            else
            {
                biggest = c;
            }
        }
        Console.WriteLine(biggest);
    }
}