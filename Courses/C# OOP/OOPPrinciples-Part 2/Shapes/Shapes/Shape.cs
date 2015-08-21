namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width 
        {
            get
            {
                return this.width;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
        }
        public Shape(double width, double height)
        {        
            this.width = width;
            this.height = height;
        }
        public virtual double CalculateSurface()
        {
            return 0;
        }
    }
}
