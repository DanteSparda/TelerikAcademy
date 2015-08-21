using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public static int solve(int[,] input)
    {

        var result = Math.Abs(rightDiagonalSolve(input) - leftDiagonalSolve(input));
        return result;
    }
    public static int rightDiagonalSolve(int[,] matrix)
    {
        var result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            result += matrix[row, row];
        }
        return result;
    }
    public static int leftDiagonalSolve(int[,] matrix)
    {
        var result = 0;
        var row = matrix.GetLength(1) - 1;
        var col = 0;
        while (row >= 0)
        {
            result += matrix[row, col];
            row--;
            col++;
        }
        return result;
    }
    static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        for (int row = 0; row < matrixSize; row++)
        {
            var lane = Console.ReadLine().Split(' ');
            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = int.Parse(lane[col]);
            }
        }

        var result = solve(matrix);
        Console.WriteLine(result);
    }
}