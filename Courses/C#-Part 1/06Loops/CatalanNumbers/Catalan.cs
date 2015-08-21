using System;
class Catalan
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            double catalan = (Factoriel(2 * n)) /(Factoriel(n + 1) * Factoriel(n));
            Console.WriteLine(catalan);
        }
        static double Factoriel(double i)
        {
            double result = 1;
            for (int j = 1; j <= i; j++)
            {
                result *= j;
            }
            return result;
        }
    }
