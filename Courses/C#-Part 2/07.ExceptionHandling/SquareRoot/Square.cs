using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Square
    {
        static void Main()
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine( Math.Sqrt(input));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }

