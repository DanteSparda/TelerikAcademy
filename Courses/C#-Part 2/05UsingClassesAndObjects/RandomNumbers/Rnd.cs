using System;
    class Rnd
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
               
                Console.WriteLine( rnd.Next(100, 200));
            }
        }
   }

