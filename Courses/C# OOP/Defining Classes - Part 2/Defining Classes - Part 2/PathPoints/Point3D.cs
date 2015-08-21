namespace Defining_Classes___Part_2.PathPoints
{
    public struct Point3D
    {
        private static readonly string PointStartO = @"{0, 0, 0}";

        public static string PointO
        {
            get
            {
                return PointStartO;
            }
        }

        public static double X { get; set; }

        public static double Y { get; set; }

        public static double Z { get; set; }
    }
}
