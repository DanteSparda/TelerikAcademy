/* Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double:
 * 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost. */

using System;
class FloatOrDouble
{
    static void Main()
    {
        double FirstNumber = 34.567839023;
        float SecondNumber = 12.345f;
        double ThirdNumber = 8923.1234857;
        float FourthNumber = 3456.091f;
        Console.WriteLine(FirstNumber + " <-- double");
        Console.WriteLine(SecondNumber + " <-- float");
        Console.WriteLine(ThirdNumber + " <-- double");
        Console.WriteLine(FourthNumber + " <-- float");
    }
}
