using System;
class ReadIntDoubleString
{
    static void Main()
    {
        string chooseType = Console.ReadLine();
        string chooseValue = Console.ReadLine();

        if (chooseType == "integer")
        {
            Console.WriteLine(int.Parse(chooseValue) + 1);
        }
        else if (chooseType == "real")
        {
            Console.WriteLine("{0:F2}", double.Parse(chooseValue) + 1);
        }
        else
        {
            Console.WriteLine(chooseValue + "*");
        }
    }
}