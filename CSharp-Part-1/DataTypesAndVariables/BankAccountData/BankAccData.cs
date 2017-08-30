//Problem 11. Bank Account Data

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
class BankAccData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Georgiev";
        string lastName = "Petrov";
        string bankName = "BULBANK";
        string iban = "UCSDFDQW42003201";
        int balance = 123012421; // The balance could be negative if the customer has 0.00 and bank taxes are paid at that moment
        ulong creditCard_1 = 1234123412341234;
        ulong creditCard_2 = 1234123412341234;
        ulong creditCard_3 = 1234123412341234;
    }
}
