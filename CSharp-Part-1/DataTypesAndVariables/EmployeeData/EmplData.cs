//Problem 10. Employee Data

//A marketing company wants to keep record of its employees.Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender(m or f)
//Personal ID number(e.g. 8306112507)
//Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.Print the data at the console.

using System;
using System.Numerics;

class EmplData
{
    static void Main()
    {
        Console.Write("Enter First name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter Gender (m or f): ");
        char gender = char.Parse(Console.ReadLine());

        Console.Write("Enter Personal ID: ");
        ulong personalID = ulong.Parse(Console.ReadLine());

        BigInteger employeeID = personalID * personalID; // Example of a very large number

        Console.WriteLine("\nFirst name: {0} \nLast Name: {1} \nAge: {2} \nGender: {3} \nPersonal ID: {4} \nEmployee ID: {5}", firstName, lastName, age, gender, personalID, employeeID);
    }
}