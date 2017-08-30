using System;

class CalculateAge
{
    static void Main(string[] args)
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Today.Year - birthday.Year;
        if (birthday > DateTime.Today.AddYears(-age))
        {
            age--;
        }
        if (age < 0)
        {
            age = 0;
        }
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}