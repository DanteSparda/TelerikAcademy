using System;
/* Problem 9. Matrix of Numbers
Write a program that reads from the console a positive integer 
 * number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. */
    class Matrix
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int column = 1;
            for (int row  = 0; row  < n; row ++)

            {
                for (int count = 1; count <= n; count++)
                {
                    Console.Write("{0}", count + row);
                    if (count != n)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
                
            }
        }
    }
