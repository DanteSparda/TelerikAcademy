using System;
/* Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/
    class Calculate
    {
        static void Main()
        {
                    Console.WriteLine("Enter your two numbers seperated by space: n x");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int n = int.Parse(inputArray[0]);
        int k = int.Parse(inputArray[1]);
        double result = Factoriel(n) / Factoriel(k);
        Console.WriteLine(result);
        }
        static double Factoriel(double i)
        {
            int result = 1;
            for (int j = 1; j <= i; j++)
            {
                result *= j;
            }
            return result;
        }
    }

