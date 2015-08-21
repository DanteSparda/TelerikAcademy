/* Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/

using System;
    class BiggestOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a,Math.Max(b,c)));
        }
    }
