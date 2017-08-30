using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double number, biggest, smallest, sum = 0, average;
        number = double.Parse(Console.ReadLine());
        smallest = number;
        biggest = number;
        sum += number;
        for (int i = 1; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());
            if (biggest < number)
            {
                biggest = number;
            }
            if (smallest > number)
            {
                smallest = number;
            }
            sum += number;
        }
        average = sum / n;
        Console.WriteLine("min={0:F2}", smallest);
        Console.WriteLine("max={0:F2}", biggest);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}