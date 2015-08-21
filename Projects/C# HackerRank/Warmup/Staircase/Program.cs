using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main()
        {
            var staircaseHeight = int.Parse(Console.ReadLine());

            for (int i = 0; i < staircaseHeight; i++)
            {
                Console.Write(new string(' ',staircaseHeight-1-i));
                Console.Write(new string('#',i+1));
                Console.WriteLine();
            }
        }
    }
}
