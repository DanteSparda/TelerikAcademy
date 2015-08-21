namespace Defining_Classes___Part_2.PathPoints
{
    public static class StaticClass
    {
        private static readonly double FirstPoint = 13.21;
        private static readonly double SecondPoint = 11.12;

        public static double DistanceBetweenTwoPoints()
        {
            return FirstPoint - SecondPoint;
        }
    }
}
