/* Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/

using System;
    class ExtractBit
    {
        static void Main()
        {
            Console.Write("Enter your nubmer: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter your position: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int morphing = mask & number;
            int result = morphing >> position;
            Console.WriteLine(result);

        }
    }
