/* Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2). */

using System;
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            if (Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2) <= 4)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }
    }
