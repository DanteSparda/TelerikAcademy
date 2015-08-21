/* Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

using System;
class Fibonacci
{
    static void Main()
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            if(number<1)
            {
                Console.WriteLine("no numbers");
            }
            else if (number == 2)
            {
                Console.WriteLine("0 1");
            }

            else if (number == 3)
            {
                Console.WriteLine("0 1 1 ");
            }

            else
            {

                string result = "";
                int[] fibonacciNumber = new int[number];
                fibonacciNumber[0] = 0;
                fibonacciNumber[1] = 1;
                fibonacciNumber[2] = 1;
                for (int i = 3; i < number; i++)
                {
                    fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];
                }
                Console.WriteLine(string.Join(" ",fibonacciNumber));
            }
        }
}
