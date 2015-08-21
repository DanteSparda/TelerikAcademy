/* Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle
 * K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;
    class Points
    {
        static void Main()
        {
            Console.Write("Please enter coordinate X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter coordinate Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double r = 1.5;
            bool inCircle = (Math.Pow((x - 1),2)+Math.Pow((y - 1),2)) <= Math.Pow(r, 2);
            bool outRectangle = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
            bool checkCond = inCircle && outRectangle;
            Console.WriteLine(checkCond);


        }
    }
