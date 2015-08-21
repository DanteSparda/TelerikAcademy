/* Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;
    class Area
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area is: {0}",((a+b)/2)*h);
        }

    }
