using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class Odd
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("..\\..\\OddLines.txt");
            int i = 1;
            using (reader)
            {
                string currentLine = reader.ReadLine();
                do
                {
                    if (i % 2 != 0)
                    {

                        Console.WriteLine(currentLine);
                        currentLine = reader.ReadLine();
                    }
                    else
                    {
                        currentLine = reader.ReadLine();
                    }

                    i++;
                } while (currentLine != null);
            }
        }
    }
}
