using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class SubStrings
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string input = Console.ReadLine();
            Console.WriteLine("Enter substring");
            string substring = Console.ReadLine();
            int index = 0;
            int start = 0;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                index = input.IndexOf(substring, start);
                if (index>-1)
                {
                    start = index+1;
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
