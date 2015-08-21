using System;
using System.Linq;
class Sorting
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] input = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            input[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter your index: ");
        int index = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Your Array: ");
        foreach (var item in input)
        {
            Console.Write("{0} ", item);
        }
      int result =   MaximalElement(input, index);
      Console.WriteLine();
      Console.Write("The number is: ");
        Console.WriteLine(result);
        Console.Write("In descending order: ");
        SortDescending(input);
        Console.WriteLine();
        Console.Write("In ascending order: ");
        SortAscending(input); 
    }
    static int MaximalElement(int[] input, int index)
    {
                int max = int.MinValue;
        if (index==input.Length-1)
        {
            max = input[index];
        }

        for (int element = index; element < input.Length; element++)
        {
            if (input[element]>max)
            {
                max = input[element];
            }
        }
        return max;
    }

    static void SortDescending(int[] input)
    {
        Array.Sort<int>(input,
            delegate(int a, int b)
            {
                return b - a;
            });
        foreach (var number in input)
        {
            Console.Write("{0} ",number);
        }
    }
    static void SortAscending(int[] input)
    {
        Array.Sort(input);
        foreach (var number in input)
        {
            Console.Write("{0} ", number);
        }
    }
}

