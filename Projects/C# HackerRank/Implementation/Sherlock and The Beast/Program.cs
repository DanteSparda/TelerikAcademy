using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_The_Beast
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var c = 5 * (2 * n % 3);
                if (c > n)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(new string('5',(n-c)) + new string('3',c));
                }
            }

        }
    }
}
