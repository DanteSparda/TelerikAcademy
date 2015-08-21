/* Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7. */

using System;
class IsItSeven
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int a = int.Parse(Console.ReadLine());
        int theNumber = (a / 100) % 10;
        if (theNumber == 7)
        {
            Console.WriteLine("true");
        }
        else
            Console.WriteLine("false");
    }
}
