using System;

    class Length
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("The length is too long");
            }
            else if (input.Length < 20)
            {
                do
                {
                    input = string.Concat(input, "*");
                } while (input.Length<20);
                
            }
            Console.WriteLine(input);
            
        }
    }

