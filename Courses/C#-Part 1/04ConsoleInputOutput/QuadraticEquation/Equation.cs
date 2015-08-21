/* Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;
class Equation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double D = b * b - (4 * a * c);
        double xOne = (-b + Math.Sqrt(D)) / (2 * a);
        double xTwo = (-b - Math.Sqrt(D)) / (2 * a);
        if(double.IsNaN(xOne) || double.IsNaN(xTwo))
        {
            Console.WriteLine("No real roots.");
        }
        else if (xOne==xTwo)
        {
            Console.WriteLine("x1=x2={0}",xOne);
        }
        else
        {
            Console.WriteLine("x1={0}; x2={1}",xTwo,xOne);
        }
    }
}

