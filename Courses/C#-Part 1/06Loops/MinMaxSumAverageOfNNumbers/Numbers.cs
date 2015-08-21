using System;
using System.Linq;
using System.Collections.Generic;
/* Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns
the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.*/
    class Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, max = int.MaxValue, min = int.MinValue; 
            double avg = 0;
            List<int> minMax = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                minMax.Add(a);
                
            }
            int[] minMaxArray = minMax.ToArray();
            max = minMaxArray.Max();
            min = minMaxArray.Min();
            avg = (double)sum / n;
            Console.WriteLine("min = {0}",min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:0.00}", avg);
        }
    }

