using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palind
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            List<string> result = new List<string>();
            foreach (var word in inputArr)
            {
                char[] mask = word.ToCharArray();
                Array.Reverse(mask);
                string reversed = string.Join("", mask);
                if (word==reversed)
                {
                    result.Add(word);
                }
            }
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
