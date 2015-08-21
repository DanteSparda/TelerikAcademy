namespace Defining_Classes___Part_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Defining_Classes___Part_2.GenericClasses;
    using Defining_Classes___Part_2.PathPoints;

    public class TestingAll
    {
        [Version("1.01")]
        private static void Main()
        {
            // Points
            Point3D.Z = 12;
            Console.WriteLine(Point3D.Z);
            Console.WriteLine(Point3D.PointO);
            double betweenTwoPoints = StaticClass.DistanceBetweenTwoPoints();
            Console.WriteLine(betweenTwoPoints);

            Path testingPath = new Path(12.32);
            testingPath.AddPointAndPrintAllPoints(12.12);
            PathStorage.AddPoints("123 123 123");
            PathStorage.ReadPoints();

            // Generic list
            var list = new GenericList<int>(1);

            // Resizeing
            Console.WriteLine(list.Length);
            list.Add(1);
            list.Add(2);
            Console.WriteLine(list.Length);
            list.Add(-2);
            Console.WriteLine(list.Length);
            list.Add(2);
            Console.WriteLine(list.Length);
            list.Add(122);
            Console.WriteLine(list.Length);

            // Max and min
            var max = list.Max();
            Console.WriteLine(max);
            var min = list.Min();
            Console.WriteLine(min);

            // Removes 3
            list.RemoveAt(2);
            Console.WriteLine();

            // Inserting at position
            list.InsertAt(0, 133);

            // Printing
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            // To String
            Console.WriteLine();
            string toString = list.ToString();
            Console.WriteLine(toString);

            // Empty the array
            Console.WriteLine();
            list.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Add(1);
            list.Add(2);
            list.Add(3);

            // FindingIndex
            Console.WriteLine();
            var find = list.IndexOf(2);
            Console.WriteLine(find);

            // Testing the matrix
            var matrixOne = new Matrix<int>(3, 3);
            matrixOne.Add(1);
            matrixOne.Add(1);
            matrixOne.Add(1);
            matrixOne.Add(1);
            var matrixTwo = new Matrix<int>(3, 3);
            matrixTwo.Add(2);
            matrixTwo.Add(2);
            matrixTwo.Add(2);
            matrixTwo.Add(2);
            var newMatrix = matrixOne + matrixTwo;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    // if you change the 0 to any other number or whatever the if below will return true 
                    newMatrix[row, col] = 0;
                    Console.Write(newMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            if (newMatrix)
            {
                Console.WriteLine("The matrix statement is true");
            }
        }
    }
}
