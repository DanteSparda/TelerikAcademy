using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
*/
    class FindSum
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
            Console.WriteLine("Enter S: ");
            int s = int.Parse(Console.ReadLine());

             bool noSolution = true;
        int allSum = 0;

        for (int i = 0; i < inputIntArray.Length; i++) 
        {
            allSum = allSum + inputIntArray[i]; 
            int currSum = allSum;
            for (int j = 0; j <= i; j++) 
            {
                if (currSum == s) 
                {
                    Console.Write("Sum = {0} ->", s);
                    for (int k = j; k <= i; k++)
                        Console.Write("{0,3}", inputIntArray[k]);
                    Console.WriteLine();
                    noSolution = false;
                }
                currSum = currSum - inputIntArray[j]; 
            }   
        }
        if (noSolution)
        {
            Console.WriteLine("There is no sequence with sum of {0}",s);
        }
        }
    }

