using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace A_very_big_sum
{
    class Program
    {
        static void Main()
        {
            var inputLength = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            var arrayOfInput = new BigInteger[inputLength];
            var sum = new BigInteger();
            for (int i = 0; i < arrayOfInput.Length; i++)
            {
                sum += BigInteger.Parse(input[i]);
            }
            Console.WriteLine(sum);

        }
    }
}
