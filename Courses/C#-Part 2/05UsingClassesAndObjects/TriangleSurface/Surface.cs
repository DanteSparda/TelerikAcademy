using System;
    class Surface
    {
        static void Main()
        {
            triangleSurfaceBySideAndAltitude();
            triangleSurfaceByThreeSides();
            triangleSurfaceByTwoSidesAndAngle();
        }
        static void triangleSurfaceBySideAndAltitude()
        {
            Console.WriteLine("Enter the side: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Altitude (h): ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The result is {0}", (side * h) / 2);
        }
        static void triangleSurfaceByThreeSides()
        {
            Console.WriteLine("Enter the a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the c: ");
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            Console.WriteLine("The result is {0}",Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
           /* a+b+c/2 p malko = korenkvadr ot (p*p-a*p-b*p-c)*/
        }
        static void triangleSurfaceByTwoSidesAndAngle()
        {
            /* (a*b*sin(ugul))/2 */
            Console.WriteLine("Enter the a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the angle: ");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("The result is {0}",(a*b*Math.Sin(angle))/2);
        }
    }

