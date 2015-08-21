using System;
/* Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element. */ 
class Compare
{
    static void Main()
    {
        Console.WriteLine("Enter the first array (numbers separated by space)");
        string intputOne = Console.ReadLine();
        string[] inputOneString = intputOne.Split(' ');
        int[] inputOneIntArray = new int[inputOneString.Length];
        for (int i = 0; i < inputOneString.Length; i++)
        {
            inputOneIntArray[i] = int.Parse(inputOneString[i]);

        }
        Console.WriteLine("Enter the first array (numbers separated by space)");
        string intputTwo = Console.ReadLine();
        string[] inputTwoString = intputTwo.Split(' ');
        int[] inputTwoIntArray = new int[inputTwoString.Length];
        for (int i = 0; i < inputTwoString.Length; i++)
        {
            inputTwoIntArray[i] = int.Parse(inputTwoString[i]);

        }
        bool areEqual = false;
        if (inputOneIntArray.Length == inputTwoIntArray.Length)
        {
            for (int i = 0; i < inputTwoIntArray.Length; i++)
            {
                if (inputOneIntArray[i] == inputTwoIntArray[i])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                    break;
                }
            }
        }
        Console.WriteLine("The arrays are equal: {0}",areEqual);
    }
}
