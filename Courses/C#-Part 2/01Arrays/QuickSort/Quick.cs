using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm. */

class Quick
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array (numbers separated by space)");
        string input = Console.ReadLine();
        input = input.Replace(",", "").Trim();
        List<string> inputString = new List<string>(input.Split(' '));
        List<int> inputIntArray = new List<int>(inputString.Count);
        List<int> result = new List<int>(inputString.Count);

        foreach (var number in inputString)
        {
            inputIntArray.Add(int.Parse(number));
        }
        Quicksort(inputIntArray, 0, inputIntArray.Count - 1);
        foreach (var number in inputIntArray)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine("\n \n \n Tadaaa!!   \n             also i broke my pc...");
        Console.WriteLine();
    }

    public static void Quicksort(List<int> elements, int left, int right)
    {
        int i = left, j = right;
        int pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }


}