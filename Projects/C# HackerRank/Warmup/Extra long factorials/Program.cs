using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Extra_long_factorials
{
    class Program
    {
        public static BigInteger Factoriel(int number)
        {
            if (number<=1)
            {
                return 1;
            }
            return number * Factoriel(number - 1);
        }
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(input));
        }
    }
}
