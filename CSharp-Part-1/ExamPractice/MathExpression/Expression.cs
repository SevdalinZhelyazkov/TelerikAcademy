using System;
using System.Globalization;
using System.Threading;

class Expression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F6}", ((n * n + 1 / (m * p) + 1337) / (n - 128.523123123 * p)) + Math.Sin(m % 180));
    }
}
