using System;
/* Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

    class Random
    {
        static void Main()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max: ");
            int max = int.Parse(Console.ReadLine());
            if (min == max)
            {
                Console.WriteLine("wrong input");
            }
            else
            {
                Random rnd = new Random();
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", rnd.Next(min, max + 1));
                }
            }

            // I have no idea why this f**** Next won't work...
        }
    }
