/* Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names. */

using System;
class BankData
{
    static void Main()
    {
        string FirstName, MiddleName, LastName, BankName, IBAN, CreditCardOne, CreditCardTwo, CreditCardThree;
        int Balance;

        FirstName = "Ivan ";
        MiddleName = "Ivanov ";
        LastName = "Ivanov";
        BankName = "WeRichYouPoor";
        IBAN = "371289blabla12";
        CreditCardOne = "12367858901234";
        CreditCardTwo = "61237812547219";
        CreditCardThree = "267340917294923";
        Console.WriteLine("Name: {0}\nBank name: {1}\nIBAN: {2}\nCredit cards:{3}  {4}  {5}", FirstName + MiddleName + LastName, BankName, IBAN, CreditCardOne, CreditCardTwo, CreditCardThree);
    }
}

