using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Fine
{
    class Program
    {
        static void Main()
        {
            var returnDate = Console.ReadLine().Split(' ');
            var expectedDate = Console.ReadLine().Split(' ');
            int fine = 0;

            if (expectedDate[2] != returnDate[2])
            {
                if (int.Parse(returnDate[2]) > int.Parse(expectedDate[2]))
                    fine = 10000;
            }
            else if (expectedDate[1] != returnDate[1])
            {
                fine = (Math.Max(int.Parse(returnDate[1]) - int.Parse(expectedDate[1]), 0)) * 500;
            }
            else
            {
                fine = (Math.Max(int.Parse(returnDate[0]) - int.Parse(expectedDate[0]), 0)) * 15;
            }
            Console.WriteLine(fine);
        }

    }
}
