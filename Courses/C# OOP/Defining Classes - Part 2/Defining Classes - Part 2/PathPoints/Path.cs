namespace Defining_Classes___Part_2.PathPoints
{
    using System.Collections.Generic;

   public class Path
    {
        private List<double> pathSeq;

        public Path(double fistPoint)
        {
            this.pathSeq = new List<double>();
            this.pathSeq.Add(fistPoint);
        }

        public void AddPointAndPrintAllPoints(double point)
        {
            this.pathSeq.Add(point);
            foreach (var item in this.pathSeq)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
