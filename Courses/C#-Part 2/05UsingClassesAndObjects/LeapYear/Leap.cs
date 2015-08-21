using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Leap
    {
        static void Main()
        {
            Console.WriteLine("Enter year: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(input));

        }
    }

