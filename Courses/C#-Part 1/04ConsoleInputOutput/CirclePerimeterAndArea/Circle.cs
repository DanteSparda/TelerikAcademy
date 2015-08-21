/* Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

using System;
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Enter r: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter = {0:0.00}\nArea = {1:0.00}",(Math.PI*2*radius),(Math.Pow(radius,2)*Math.PI));
        }
    }
