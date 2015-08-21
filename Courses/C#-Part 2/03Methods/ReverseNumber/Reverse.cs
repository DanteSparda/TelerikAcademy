using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            ReverseNumber(input);
        }
        static void ReverseNumber(string input)
        {
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string result = string.Join("", charArr);
            Console.WriteLine(result);
        }
    }
}
