/* Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. */

using System;
class ModifyABit
{
    static void Main()
    {
        Console.Write("Enter your nubmer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter your position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter your bit value: ");
        int bitValue = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int morphing = mask & number;
        int result = morphing >> position;
        if (result == 1)
        {
            if (result == bitValue)
            {
                Console.WriteLine(number);
            }
            else
            {
                int resultOne = number & ~mask;
                Console.WriteLine(resultOne);
            }
        }
        else
        {
            if (result == bitValue)
            {
                Console.WriteLine(number);
            }
            else
            {
                int resultOne = number | mask;
                Console.WriteLine(resultOne);
            }
        }

    }
}
