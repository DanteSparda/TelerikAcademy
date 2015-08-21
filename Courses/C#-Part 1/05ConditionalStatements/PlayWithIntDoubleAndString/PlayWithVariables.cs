/* Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;
    class PlayWithVariables
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": Console.Write("Please enter an int: ");
                    int numberInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(++numberInt);
                    break;
                case "2": Console.Write("Please enter a double: ");
                    double numberDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(++numberDouble);
                    break;
                case "3": Console.Write("Please enter a string: ");
                    string caseString = Console.ReadLine();
                    Console.WriteLine(caseString + '*');
                    break;
                default: Console.WriteLine("Invalid input {0}",input);
                    break;
            }
        }
    }
