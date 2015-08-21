using System;
using System.Linq;
    class Calculations
    {
        static void Main()
        {
            Console.Write("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ", i);
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            foreach (var item in input)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Min(input);
            Max(input);
            Avg(input);
            Sum(input);
            Product(input);
        }
        static void Max(int[] input)
        {
            int max = input.Max();
            Console.WriteLine("The biggest number is: {0}",max);
        }
        static void Min(int[] input)
        {
            int min = input.Min();
            Console.WriteLine("The smallest number is: {0}", min);
        }
        static void Avg(int[] input)
        {
            double length = input.Length;
            double sum = input.Sum();
            double avg = sum/length ;
            Console.WriteLine("The average number is: {0}", avg);
        }
        static void Sum(int[] input)
        {
            int sum = input.Sum();
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
        static void Product(int[] input)
        {
            int product = 1;
            foreach (var number in input)
            {
                product *= number;
            }
            Console.WriteLine("The product of the numbers is: {0}", product);
        }
    }

