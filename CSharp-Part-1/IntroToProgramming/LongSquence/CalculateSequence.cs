using System;

class CalculateSequence
{
    static void Main(string[] args)
    {
        int sequenceNumber = 2;
        int sequenceLength = 1000;

        for (int i = 0; i < sequenceLength; i++)
        {
            Console.WriteLine(sequenceNumber % 2 == 0 ? sequenceNumber : sequenceNumber * (-1));
            sequenceNumber++;
        }
    }
}