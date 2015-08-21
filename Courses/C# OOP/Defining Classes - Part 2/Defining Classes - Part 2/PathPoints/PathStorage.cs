namespace Defining_Classes___Part_2.PathPoints
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class PathStorage
    {
        /// <summary>
        /// Adding points
        /// </summary>
        /// <param name="points">format "x y z"</param>
        public static void AddPoints(string points)
        {
            var writer = new StreamWriter("..//..//PathPoints.txt");
            using (writer)
            {
                writer.WriteLine(points);
            }
        }

        public static void ReadPoints()
        {
            var reader = new StreamReader("..//..//PathPoints.txt");
            using (reader)
            {
                string output = reader.ReadLine();
                while (output != null)
                {
                    Console.WriteLine(output);
                    output = reader.ReadLine();
                }
            }
        }
    }
}
