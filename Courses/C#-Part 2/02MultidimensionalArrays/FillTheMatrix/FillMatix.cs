using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that fills and prints a matrix of size (n, n) as shown below: */
class FillMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] input = new int[n, n];
        firstMatrix(input);
        Console.WriteLine();
        secondMatix(input);
        Console.WriteLine();
        thirdMatrix(input);
        Console.WriteLine();
        fourthMatrix(input);
        printMatrix(input);



    }
    static void firstMatrix(int[,] inputArray)
    {
        int theNumber = 1;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(0); j++)
            {
                inputArray[j, i] = theNumber;
                theNumber++;
            }
        }
        printMatrix(inputArray);
    }
    static void secondMatix(int[,] inputArray)
    {
        bool goingDown = true;
        int theNumber = 1;
        int magic = 0;
        int pathCounter = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(0); j++)
            {
                if (goingDown)
                {
                    inputArray[magic, i] = theNumber;
                    theNumber++;
                    magic++;
                }
                else
                {
                    magic--;
                    inputArray[magic, i] = theNumber;
                    theNumber++;
                }
            }
            if (goingDown == true)
            {
                goingDown = false;
            }
            else
            {
                goingDown = true;
            }
        }
        printMatrix(inputArray);

    }
    static void printMatrix(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(0); j++)
            {
                Console.Write("{0} ", inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void thirdMatrix(int[,] inputArray)
    {
        int row = inputArray.GetLength(0) - 1, col = 0, data = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            do
            {
                data++;
                if (row < 0) row = 0;
                inputArray[row, col] = data;
                row++;
                col++;
            } while (row < inputArray.GetLength(0));

            row -= col + 1;
            col = 0;
        }

        row = 0;
        col = 1;
        for (int i = 0; i < inputArray.GetLength(0) - 1; i++)
        {
            do
            {
                data++;
                inputArray[row, col] = data;
                row++;
                col++;
            } while (col < inputArray.GetLength(0));

            col -= row - 1;
            row = 0;

        }
        printMatrix(inputArray);

    }
    static void fourthMatrix(int[,] inputArray)
    {

        int offset = 0;
        int digit = 1;
        int n = inputArray.GetLength(0);
        int ROW = 0;
        int COL = 0;
        while (digit <= n * n)
        {
            for (ROW = offset; ROW < n - offset; ROW++)
            {
                COL = offset;
                inputArray[ROW, COL] = digit;
                digit++;
            }
            for (COL = 1 + offset; COL < n - offset; COL++)
            {
                ROW = n - 1 - offset;
                inputArray[ROW, COL] = digit;
                digit++;
            }
            for (ROW = n - 2 - offset; ROW >= offset; ROW--)
            {
                COL = n - 1 - offset;
                inputArray[ROW, COL] = digit;
                digit++;
            }
            for (COL = n - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                inputArray[ROW, COL] = digit;
                digit++;
            }
            offset++;
        }
    }
    static bool IsTraversable(int[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLongLength(0) &&
               col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
    }
}

