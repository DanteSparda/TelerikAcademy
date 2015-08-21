/* Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.*/

using System;
    class Comparing
    {
        static void Main()
        {
            string nl = "\n";
            double a = 5.3, b = 6.01,
                   c = 5.00000001, d = 5.00000003,
                   c2 = 5.00000005, d2 = 5.00000001,
                   e = -0.0000007, f = 0.00000007,
                   g = -4.999999, h = -4.999998,
                   g2 = 4.999999, h2 = 4.999998;
            double eps = 0.000001;
            bool AB = Math.Abs(a - b) < eps,
                 CD = Math.Abs(c - d) < eps,
                 EF = Math.Abs(e - f) < eps,
                 GH = Math.Abs(g - h) < eps,
                 C2D2 = Math.Abs(c2 - d2) < eps,
                 G2H2 = Math.Abs(g2 - h2) < eps;
            Console.WriteLine(AB);
            Console.WriteLine(CD);
            Console.WriteLine(EF);
            Console.WriteLine(C2D2);
            Console.WriteLine(GH);
            Console.WriteLine(G2H2);

            
            
        }
    }
