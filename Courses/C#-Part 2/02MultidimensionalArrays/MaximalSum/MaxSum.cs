using System;
/* Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/
class MaxSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 3)
        {
            Console.WriteLine("N must be >= 3");
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        if (m < 3)
        {
            Console.WriteLine("M must be >= 3");
            Console.Write("Enter M: ");
            m = int.Parse(Console.ReadLine());
        }
        int[,] input = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter number at [{0},{1}]: ", row, col);
                input[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
        Console.WriteLine("This is how it looks:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write(input[row, col] + " ");
            }
            Console.WriteLine();
        }

        int maxSum = int.MinValue;
        int rowForResult = 0, colForResult = 0;

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int firstRow = input[row, col] + input[row, col + 1] + input[row, col + 2];
                int secondRow = input[row + 1, col] + input[row + 1, col + 1] + input[row + 1, col + 2];
                int thirdRow = input[row + 2, col] + input[row + 2, col + 1] + input[row + 2, col + 2];
                int sum = firstRow + secondRow + thirdRow;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    rowForResult = row;
                    colForResult = col;
                }
            }
        }
        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1} {2}", input[rowForResult, colForResult], input[rowForResult, colForResult + 1], input[rowForResult, colForResult + 2]);
        Console.WriteLine("  {0} {1} {2}", input[rowForResult + 1, colForResult], input[rowForResult + 1, colForResult + 1], input[rowForResult + 1, colForResult + 2]);
        Console.WriteLine("  {0} {1} {2}", input[rowForResult + 1, colForResult], input[rowForResult + 1, colForResult + 1], input[rowForResult + 2, colForResult + 2]);
        Console.WriteLine("The max sum is: {0}", maxSum);

    }
}

