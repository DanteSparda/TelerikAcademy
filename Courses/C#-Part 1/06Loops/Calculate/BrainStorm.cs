using System;
/* Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point. */
class BrainStorm
{
    static void Main()
    {
        Console.WriteLine("Enter your two numbers seperated by space: n x");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int n = int.Parse(inputArray[0]);
        int x = int.Parse(inputArray[1]);
        double S = 1;
        for (int i = 1; i <= n; i++)
        {
            double a = Factoriel(i)/Math.Pow(x,i);
            S += a;
        }
        Console.WriteLine("{0:0.00000}",S);
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
