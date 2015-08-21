namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    abstract class ProgramStart
    {
        static void Main()
        {
            var rect = new Rectangle(12, 32.21);
            var square = new Square(12, 12);
            var tri = new Triangle(33, 12);

            Console.WriteLine(rect.CalculateSurface());
            Console.WriteLine(square.CalculateSurface());
            Console.WriteLine(tri.CalculateSurface());


            var squareCheck = new Square(12, 13);
        }
    }
}
