/* Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.*/

using System;

    class BiggestOfFive
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter a: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a,Math.Max(b,Math.Max(c,Math.Max(d,e)))));
        }
    }
