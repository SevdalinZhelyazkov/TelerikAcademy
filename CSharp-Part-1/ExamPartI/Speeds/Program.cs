using System;
namespace Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length = 1;
            int maxLength = 1;
            int maxSum = 1;
            int past = int.Parse(Console.ReadLine());
            int sum = past;

            for (int i = 1; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (past < current)
                {
                    sum += current;
                    current = past;
                    length++;
                }
                else
                {
                    length = 1;
                    if (maxSum < sum) maxSum = sum;
                    sum = current;
                }
                if (maxLength < length)
                {
                    maxLength = length;
                    maxSum = sum;
                }
                else if (maxLength == length)
                {
                    if (maxSum < sum) maxSum = sum;
                }

                past = current;
            }
            Console.WriteLine(maxSum);
        }
    }
}
