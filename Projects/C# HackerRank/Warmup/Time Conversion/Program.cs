using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static void Main()
        {

            DateTime input = DateTime.Parse(Console.ReadLine()); 
            Console.WriteLine(input.ToString("HH:mm:ss"));
        }
    }
}
