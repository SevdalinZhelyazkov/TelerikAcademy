using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double temp;
        if (a > b)
        {
            temp = b;
            b = a;
            a = temp;
        }
        Console.WriteLine(a + " " + b);
    }
}
