﻿/* Problem 6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */

using System;
    class StrAndObj
    {
        static void Main()
        {
            string Hello = "Hello";
            string World = " World";
            object Combo = Hello + World;
            string PrintedCombo = (string)Combo;
            Console.WriteLine(PrintedCombo);
        }
    }
