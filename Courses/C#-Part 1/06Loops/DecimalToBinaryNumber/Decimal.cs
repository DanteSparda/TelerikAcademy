using System;
/* Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/
    class Decimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary integer number :");
            int input = int.Parse(Console.ReadLine());
            string binary = "";
            do
            {
                if (input%2 ==0)
                {
                    binary += "0";
                }
                else if (input%2 ==1)
                {
                    binary += "1";
                }
                input /= 2;
            } while (input>0);
            char[] charArray = binary.ToCharArray();
            Array.Reverse(charArray);
            foreach (char digit in charArray)
            {
                Console.Write("{0}",digit);
            } 
            Console.WriteLine();
        }
    }

