/* Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

using System;
    class NullValues
    {
        static void Main()
        {
            int? NullInt = null;
            double? NullDouble = null;
            Console.WriteLine(NullDouble + " <--- Null Double");
            Console.WriteLine(NullInt+" <--- Null Int");
            NullDouble += 12.21;
            NullInt += 45;
            Console.WriteLine(NullDouble + " <--- Null Double + 12.21");
            Console.WriteLine(NullInt + " <--- Null Int + 45");
        }
    }
