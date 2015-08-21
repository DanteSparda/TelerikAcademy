using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.*/

namespace SequenceNmatrix
{
    class Sequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter M: ");
            int m = int.Parse(Console.ReadLine());

            string[,] input = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Enter word at [{0},{1}]: ", row, col);
                    input[row, col] = Console.ReadLine();
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
            string currElement = "";
            string element = "";
            int maxSeq = 0;
            int currSeq = 0;
            //cols
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    element = input[row, col];
                    string nextOnLine = input[row, col + 1];
                    if (element == nextOnLine)
                    {
                        currSeq++;
                    }
                    if (currSeq > maxSeq)
                    {
                        maxSeq = currSeq;
                        currElement = element;
                    }

                }
            }
            currSeq = 0;
            //rows
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    element = input[row, col];
                    string nextOnLine = input[row + 1, col];
                    if (element == nextOnLine)
                    {
                        currSeq++;
                    }
                    if (currSeq > maxSeq)
                    {
                        maxSeq = currSeq;
                        currElement = element;
                    }

                }
            }
            currSeq = 0;
            //diagonals

            for (int i = 0; i < input.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < input.GetLength(1) - 1; j++)
                {
                    for (int row = i, col = j; row < input.GetLength(0) - 1 && col < input.GetLength(1) - 1; row++, col++)
                    {
                        if (input[row, col] == input[row + 1, col + 1])
                        {
                            currSeq++;
                        }
                        else
                        {
                            currSeq = 1;
                        }

                        if (currSeq > maxSeq)
                        {
                            maxSeq = currSeq;
                            currElement = element;

                        }
                    }
                }
                currSeq = 1;
            }

            for (int i = 0; i < input.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < input.GetLength(1); j++)
                {
                    for (int row = i, col = j; row < input.GetLength(0) - 1 && col > 0; row++, col--)
                    {
                        if (input[row, col] == input[row + 1, col - 1])
                        {
                            currSeq++;
                        }
                        else
                        {
                            currSeq = 1;
                        }

                        if (currSeq > maxSeq)
                        {
                            maxSeq = currSeq;
                            currElement = element;
                        }
                    }
                }

                for (int omg = 0; omg < maxSeq; omg++)
                {
                    if (omg != maxSeq - 1)
                    {
                        Console.Write("{0}, ", currElement);
                    }
                    else
                    {
                        Console.Write(currElement);
                    }

                }

            }
        }
    }
}
