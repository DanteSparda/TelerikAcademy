using System;
using System.Linq;

namespace hackerrank
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            double positive = 0.000, negative = 0.000, zero = 0.000;
            var len = input.Length;
            for (int i = 0; i < len; i++)
            {
                int currNumber = int.Parse(input[i]);
                if (currNumber > 0)
                {
                    positive++;
                }
                else if (currNumber < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            double zeroResult = zero / len;
            var positiveResult = positive / len;
            var negativeResult = negative / len;

            Console.WriteLine(String.Format("{0:F3}", positiveResult));
            Console.WriteLine(String.Format("{0:F3}", negativeResult));
            Console.WriteLine(String.Format("{0:F3}", zeroResult));

        }
    }
}