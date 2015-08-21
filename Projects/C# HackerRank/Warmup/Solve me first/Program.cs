using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int solveMeFirst(int a, int b)
    {
        return a + b;
    }
    static void Main()
    {
        int val1 = int.Parse(Console.ReadLine());
        int val2 = int.Parse(Console.ReadLine());
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine(sum);
    }
}