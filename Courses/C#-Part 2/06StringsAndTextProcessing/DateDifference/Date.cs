using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class Date
    {
        static void Main()
        {
            Console.Write("first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan result = secondDate.Subtract(firstDate);
            Console.WriteLine("Distance: {0} days",result.Days);
        }
    }
}
