/* Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. */

using System;
    class FourDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            if (number<1000 || number>9999)
            {
                Console.WriteLine("Enter four digit number");
            }
            else
            {
                int d = number % 10;
                number /= 10;
                int c = number % 10;
                number /= 10;
                int b = number % 10;
                number /= 10;
                int a = number % 10;
                number /= 10;
                Console.WriteLine("The sum of the digits is: {0}", a + b + c + d);
                Console.WriteLine("The number in reversed order is: {0}{1}{2}{3}", d, c, b, a);
                Console.WriteLine("The number with first and last digits swapped: {0}{1}{2}{3}", d, a, b, c);
                Console.WriteLine("The number with second and third digits swapped: {0}{1}{2}{3}", a, c, b, d);
            }
        }
    }

