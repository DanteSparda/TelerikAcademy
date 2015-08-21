using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the
array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

namespace BinarySearch
{
    class Binary
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number at position {0}: ", i);
                input[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(input);
            int search = k;
            while (Array.BinarySearch(input, k) <= 0)
            {
                k--;
            }
            Console.WriteLine("The number which is less or equal to {1} is {0}", k, search);
        }
    }
}
