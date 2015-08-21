using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Professor
{
    class Program
    {
        static void Main()
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var firstLine = Console.ReadLine().Split(' ');
                var studentsRequired = int.Parse(firstLine[1]);
                var arrOfStudents = Console.ReadLine().Split(' ');
                var result = arrOfStudents
                    .Where(student => int.Parse(student) <= 0);
                if (result.Count()<studentsRequired)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }                
            }
        }
    }
}
