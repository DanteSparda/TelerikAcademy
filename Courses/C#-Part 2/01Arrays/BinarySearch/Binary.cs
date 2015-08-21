using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/

    class Binary
    {
        static void Main()
        {
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
            Array.Sort(inputIntArray);
            Console.WriteLine("Enter your number: ");
            int theNumber = int.Parse(Console.ReadLine());
            int theIndex = 0;
            bool found = false;
            int split = inputIntArray.Length / 2;
            int currentNum = inputIntArray[split];
            while (theNumber != currentNum)
            {
                while (theNumber > currentNum)
                {
                    split = (inputIntArray.Length + split) / 2;
                    currentNum = inputIntArray[split];
                }
                while (theNumber < currentNum)
                {
                    split = (split) / 2;
                    currentNum = inputIntArray[split];
                }
                theIndex = split;
            }
            Console.WriteLine(theIndex);
            

        }
    }

