using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalAreaSum
{
    class Maximal
    {
        static void Main()
        {
            var reader = new StreamReader("..\\..\\Matrix.txt");
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string[] textLine = reader.ReadLine().Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(textLine[col]);
                }
            }
            reader.Close();

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
