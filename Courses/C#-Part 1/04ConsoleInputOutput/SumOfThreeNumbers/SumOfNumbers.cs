/* Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;
    class SumOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 3: ");
            double numberThree = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of all numbers is: "+(numberOne+numberTwo+numberThree));
        }
    }
