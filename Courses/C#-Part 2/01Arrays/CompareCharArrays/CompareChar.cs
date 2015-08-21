using System;
/* Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/
    class CompareChar
    {
        static void Main()
        {
            Console.WriteLine("Enter the first array (chars separated by space)");
            string intputOne = Console.ReadLine();
            string[] inputOneChar = intputOne.Split(' ');
            Console.WriteLine("Enter the second array (chars separated by space)");
            string intputTwo = Console.ReadLine();
            string[] inputTwoChar = intputTwo.Split(' ');
            bool areEqual = false;
            for (int i = 0; i < inputTwoChar.Length; i++)
            {
                if (inputOneChar[i]==inputTwoChar[i])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine("The arrays are equal: {0}",areEqual);
        }
    }
