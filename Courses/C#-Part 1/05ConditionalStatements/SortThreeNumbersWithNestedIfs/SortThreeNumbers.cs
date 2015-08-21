/* Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements. */

using System;
class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double max = 0;
        double middle = 0;
        double end = 0;

        if (a >= b && a >= c)
        {
            max = a;
            if (b >= c)
            {
                middle = b;
                end = c;
            }
            else
            {
                middle = c;
                end = b;
            }

        }
        else if (b >= a && b >= c)
        {
            max = b;
            if (a >= c)
            {
                middle = a;
                end = c;
            }
            else
            {
                middle = c;
                end = a;
            }
        }
        if (c >= b && a <= c)
        {
            max = c;
            if (b >= a)
            {
                middle = b;
                end = a;
            }
            else
            {
                middle = a;
                end = b;
            }
        }
        Console.WriteLine("{0} {1} {2}", max, middle, end);
    }
}
