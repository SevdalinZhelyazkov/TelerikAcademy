using System;
class Program
{
    static void Main(string[] args)
    {
        string face = Console.ReadLine();
        string[] faceHigh = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suit = { " of spades", " of clubs", " of hearts", " of diamonds" };
        int faceNumber;
        int.TryParse(face, out faceNumber);
        switch (face)
        {
            case "J":
                faceNumber = 11;
                break;
            case "Q":
                faceNumber = 12;
                break;
            case "K":
                faceNumber = 13;
                break;
            case "A":
                faceNumber = 14;
                break;
        }
        for (int i = 0; i <= faceNumber - 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j == 3)
                {
                    Console.WriteLine(faceHigh[i] + suit[j]);
                }
                else
                {
                    Console.Write(faceHigh[i] + suit[j] + ", ");
                }
            }
        }

    }
}