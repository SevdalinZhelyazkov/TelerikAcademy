using System;
class CheckCard
{
    static void Main()
    {
        string card = Console.ReadLine();
        int number;
        if (int.TryParse(card, out number) && number >= 2 && number <= 10)
        {
            Console.WriteLine("yes " + number);
        }
        else if (card == "J" || card == "Q" || card == "K" || card == "A")
        {
            Console.WriteLine("yes " + card);
        }
        else
        {
            Console.WriteLine("no " + card);
        }
    }
}
