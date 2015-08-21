/* Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1). */

using System;
class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1)
        {
            Console.WriteLine("false");
        }
        else if (number == 2)
        {
            Console.WriteLine("true");
        }
        else
        {
            for (int i = 2; i <= number; i++)
            {


                if (number % i != 0)
                {
                    if (i == number - 1)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("false");
                    return;
                }
            }
        }
        

    }
}
