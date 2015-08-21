using System;
using System.Collections.Generic;
using System.Linq;
/* Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/
class Sorting
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());
        string[] input = new string[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter word at position {0}: ", i);
            input[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Array.Sort(input, (x, y) => x.Length.CompareTo(y.Length));
        foreach (string s in input)
        {
            Console.WriteLine(s);
        }
    }

}

