using System;
/* Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/
    class Calculate
    {
        static void Main()
        {
            Console.WriteLine("Enter your two numbers seperated by space: n x");
            
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int n = int.Parse(inputArray[0]);
            int k = int.Parse(inputArray[1]);
            double result = Factoriel(n) / (Factoriel(k)*Factoriel(n-k));
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
