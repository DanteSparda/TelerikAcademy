using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Counting
    {
        static void Main()
        {
            Console.Write("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ",i);
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number you desire: ");
            int searchNumber = int.Parse(Console.ReadLine());
            int result = arraySearch(input,searchNumber);
            Console.WriteLine(result);
        }

        static int arraySearch(int[] input, int search)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == search)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
