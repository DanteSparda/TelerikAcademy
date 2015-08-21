using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    private static BigInteger biggestResult = long.MinValue;
    private static bool found = false;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        for (int row = 0; row < n; row++)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            for (int col = 0; col < n; col++)
            {
                array[row, col] = int.Parse(inputArr[col]);
            }
        }

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < n-4; col++)
            {
               BigInteger currentResult = Pattern(array, row, col);
               if (currentResult>biggestResult)
               {
                   biggestResult = currentResult;
               }
            }
        }
        if (found)
        {
            Console.WriteLine("YES {0}",biggestResult);
        }
       
    }
    static BigInteger Pattern(int[,] array, int currRow, int currCol)
    {
        BigInteger result = 0;
        BigInteger A = array[currRow, currCol];        //2
        BigInteger B = array[currRow, currCol + 1]-1;  //3-1=2
        BigInteger C = array[currRow, currCol + 2]-2;  //4-2=2
        BigInteger D = array[currRow+1, currCol+2]-3;  //5-3=2
        BigInteger F = array[currRow+2, currCol+2]-4;  //6-4=2
        BigInteger E = array[currRow+2, currCol+3]-5;  //7-5=2
        BigInteger G = array[currRow+2, currCol+4]-6;  //8-6=2
        if (A==B && A==C && A==D && A==F && A==E && A==G)
        {
            found = true;
            result += A + B + C + D + F + E + G + 21;
        }

        return result;
    }

}

