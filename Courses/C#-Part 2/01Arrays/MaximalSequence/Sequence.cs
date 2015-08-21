using System;
/* Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array. */
class Sequence
{
    static void Main()
    {
        Console.WriteLine("Enter the array (numbers separated by space)");
        string input = Console.ReadLine();
        input = input.Replace(",","").Trim();
        string[] inputOneString = input.Split(' ');
        int[] inputOneIntArray = new int[inputOneString.Length];


        for (int i = 0; i < inputOneString.Length; i++)
        {
            inputOneIntArray[i] = int.Parse(inputOneString[i]);
        }
     
        int currentCounter = 1;
        int maximalCounter = 0;
        int theNumber = 0;
        for (int i = 0; i < inputOneIntArray.Length - 1; i++)
        {
            if (inputOneIntArray[i] == inputOneIntArray[i + 1])
            {
                currentCounter++;
            }
            else
            {
                if (currentCounter>maximalCounter)
                {
                    maximalCounter = currentCounter;
                    currentCounter = 1;
                    theNumber = inputOneIntArray[i];
                  
                }
            }
            if (currentCounter>maximalCounter)
            {
                
                maximalCounter = currentCounter;
                currentCounter = 1;
                theNumber = inputOneIntArray[i];
            }
        }
        for (int i = 0; i < maximalCounter; i++)
        {
            Console.Write(theNumber+", ");
        }
    }
}

