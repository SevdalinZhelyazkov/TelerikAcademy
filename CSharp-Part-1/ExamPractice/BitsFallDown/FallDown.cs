using System;
class FallDown
{
    static void Main()
    {
        byte[] numbers = new byte[8];
        byte temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j >= 0; j--)
            {
                if (j == 7) continue;
                temp = numbers[j + 1];
                numbers[j + 1] |= numbers[j];
                if (numbers[j] != 0)
                {
                    numbers[j] &= temp;
                }
            }
        }

        foreach (byte i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}