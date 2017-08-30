using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";

            while (n >= 1)
            {
                result += (n % 2).ToString();
                n /= 2;
            }
            char[] splitter = result.ToCharArray();
            Array.Reverse(splitter);
            result = new string(splitter);
            Console.WriteLine(result);
        }
    }
}
