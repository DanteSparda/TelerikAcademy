﻿using System;
using System.Collections.Generic;
using System.Linq;
class MaxSUm
    {
        static void Main()
        {
            Console.WriteLine("Enter a number for N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number for K:");
            int K = int.Parse(Console.ReadLine());

            if (N < K)
            {
                Console.WriteLine("The length of subset elements must be smaller or equal than the array's length!");
                return;
            }

            int[] nums = new int[N];
            Console.WriteLine("Enter {0} number(s) to array each on separate lane:", N);
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            var bestSubsequence = FindSubsetWithMaxSum(nums, K);

            Console.WriteLine("Array's elements: {0} ", string.Join(", ", nums));
            Console.WriteLine("Subsequence with {0} element(s)", bestSubsequence.Count);
            Console.WriteLine("Maximal Sum = {0}", bestSubsequence.Sum());
            Console.WriteLine("Subset with Maximal Sum: {0}", string.Join(", ", bestSubsequence));
        }

        private static List<int> FindSubsetWithMaxSum(int[] nums, int k)
        {
            List<int> subsetWithMaxSum = new List<int>();
            Array.Sort(nums);

            for (int i = nums.Length - 1; k != 0; i--, k--)
            {
                subsetWithMaxSum.Add(nums[i]);
            }
            return subsetWithMaxSum;
        }
    }
