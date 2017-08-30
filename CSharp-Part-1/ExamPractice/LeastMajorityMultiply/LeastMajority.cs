using System;
class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        int p = 1;
        int count = 0;

        while (count != 3)
        {
            count = 0;
            if (p % n1 == 0) count++;
            if (p % n2 == 0) count++;
            if (p % n3 == 0) count++;
            if (p % n4 == 0) count++;
            if (p % n5 == 0) count++;
            p++;
        }
        Console.WriteLine(p - 1);
    }
}
