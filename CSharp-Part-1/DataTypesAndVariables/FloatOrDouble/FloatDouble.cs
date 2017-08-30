//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;
class FloatDouble
{
    static void Main()
    {
        float firstNumber = 12.345f;
        float secondNumber = 3456.091f;
        double thirdNumber = 34.567839023;
        double fourthNumber = 8923.1234857;

        Console.WriteLine("Float FirstNumber: {0}\nFloat SecondNumber: {1}\nDouble ThirdNumber: {2}\nDouble FourthNumber: {3}\n", firstNumber, secondNumber, thirdNumber, fourthNumber);
    }
}
