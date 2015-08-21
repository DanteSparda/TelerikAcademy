/* Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/
using System;
    class Comparer
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The greater is: {0}",Math.Max(firstNumber,secondNumber));
        }
    }
