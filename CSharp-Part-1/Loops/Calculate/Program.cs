using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1 + 1/x;
        long factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x, i);
        }
        
        Console.WriteLine("{0:F5}", sum);
    }
}