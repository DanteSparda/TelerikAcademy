/* Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.*/

using System;
    class CheckABit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your nubmer: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter your position: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int morphing = mask & number;
            int result = morphing >> position;
            Console.WriteLine(result == 1);
        }
    }
