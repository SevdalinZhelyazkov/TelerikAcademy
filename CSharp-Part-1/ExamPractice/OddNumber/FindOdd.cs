using System;
class FindOdd
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }
            if (count % 2 != 0)
            {
                Console.WriteLine(numbers[i]);
                break;
            }
            count = 0;
        }
    }
}