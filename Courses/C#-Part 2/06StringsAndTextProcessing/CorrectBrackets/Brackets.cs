using System;
    class Brackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int outBracket = 0;
            int inBracket = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    inBracket++;
                }
                else if (input[i] == ')')
                {
                    outBracket++;
                }

            }
            if (inBracket==outBracket)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }

