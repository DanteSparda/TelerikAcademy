using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double width, double height)
            : base(width, height)
        {
            if (width!=height)
            {
                throw new ArgumentException("Error");
            }
        }
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
