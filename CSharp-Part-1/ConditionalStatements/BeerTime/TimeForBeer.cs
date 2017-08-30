using System;
class TimeForBeer
{
    static void Main()
    {
        string time = Console.ReadLine();
        DateTime result;
        if (DateTime.TryParse(time, out result))
        {
            if (result.Hour <= 1 )
            {

            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}