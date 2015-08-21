/* Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even. */

using System;
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number odd : false");
            }
            else
            {
                Console.WriteLine("Your number odd : true");
            }

        }
    }

