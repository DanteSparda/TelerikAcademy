using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public static int Solve(string input)
    {
        var newArr = input.Split(' ');
        var result = int.Parse(newArr[0]) + int.Parse(newArr[1]);
        return result;
    }
    static void Main()
    {
        int inputLen = int.Parse(Console.ReadLine());
        for (var i = 0; i < inputLen; i++)
        {
            string nextInput = Console.ReadLine();
            int result = Solve(nextInput);
            Console.WriteLine(result);
        }
    }
}