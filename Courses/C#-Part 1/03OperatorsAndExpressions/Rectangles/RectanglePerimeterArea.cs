/* Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height. */

using System;

namespace RectanglePerimeterArea
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The rectangle perimeter is: {0}",width*2+height*2);
            Console.WriteLine("The rectangle area is: {0}", height*width);
        }
    }
}
