/* Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

using System;
    class SumOfNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            double first = double.Parse(input[0]);
            double second = double.Parse(input[1]);
            double third = double.Parse(input[2]);
            double fourth = double.Parse(input[3]);
            double fifth = double.Parse(input[4]);

            Console.WriteLine(first+second+third+fourth+fifth);
        }
    }
