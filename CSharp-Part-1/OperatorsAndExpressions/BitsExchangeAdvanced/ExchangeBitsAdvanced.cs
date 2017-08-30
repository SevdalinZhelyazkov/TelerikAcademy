using System;
class ExchangeBitsAdvanced
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long mask = 1;
        long bitsP = 0;
        long bitsQ = 0;
        if (Math.Abs(p - q) < k && p > 0 && q > 0)
        {
            Console.WriteLine("overlapping");
        }
        else if (p < 0 || q < 0 || p + k > 32 || q + k > 32)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                bitsP |= ((mask << p) & n) >> p - i;
                bitsQ |= ((mask << q) & n) >> q - i;
                n &= ~(1 << p);
                n &= ~(1 << q);
                n |= bitsQ << p - i;
                n |= bitsP << q - i;
                p++;
                q++;
            }
            Console.WriteLine(n);
        }
    }
}