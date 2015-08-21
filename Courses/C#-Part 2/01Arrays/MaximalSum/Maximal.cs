using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array. */

    class Maximal
    {
        static void Main()
        {
           

            int bestStart = 0, bestEnd = 0, bestSum = int.MinValue;
            int startIndex = 0, currentSum = 0;
            Console.WriteLine("Enter the array (numbers separated by space)");
            string input = Console.ReadLine();
            input = input.Replace(",", "").Trim();
            string[] inputString = input.Split(' ');
            int[] inputIntArray = new int[inputString.Length];
            int[] result = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                inputIntArray[i] = int.Parse(inputString[i]);
            }



            for (int i = 0; i < inputIntArray.Length; i++)
            {
                if (currentSum <= 0)
                {
                    startIndex = i;
                    currentSum = 0;
                }

                currentSum += inputIntArray[i];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = startIndex;
                    bestEnd = i;
                }
            }
            for (int i = bestStart; i <= bestEnd; i++)
		{
            Console.Write(i != bestEnd ? inputIntArray[i] + ", " : inputIntArray[i] + "\n");
		}
        }
    }

