/* Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop. */

using System;
    class SumOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int length = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= length; i++)
            {
                Console.Write("Enter number {0}: ",i);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The result is {0}", sum);
        }
    }
