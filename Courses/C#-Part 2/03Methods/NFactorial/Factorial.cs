using System;
    class Factorial
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("Enter number {0}: ", i);
               int input = int.Parse(Console.ReadLine());
               Factoriel(input);
               Console.WriteLine("Enter one of the following:\n1 - continues \n2 - stops the cycle");
               string choice = Console.ReadLine();
               if (choice == "1")
               {
                   Console.Clear();
               }
               else
               {
                   break;
               }
            }
        }
        static void Factoriel(int input)
        {
            int factoriel = 1;
            for (int i = 1; i <= input; i++)
            {
                factoriel *= i;   
            }
            Console.WriteLine(factoriel);
        }
    }

