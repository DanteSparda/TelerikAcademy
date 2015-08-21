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
            List<string> lineList = new List<string>();
            using (reader)
            {
                string currentLine = reader.ReadLine();
                do
                {
                    if (i % 2 != 0)
                    {
                        currentLine = reader.ReadLine();
                    }
                    else
                    {
                        lineList.Add(currentLine);
                        currentLine = reader.ReadLine();
                    }

                    i++;
                } while (currentLine != null);
            }
            var writer = new StreamWriter("..\\..\\OddLines.txt");
            using (writer)
            {

                foreach (var line in lineList)
                {
                    writer.WriteLine(line);
                }
            
            }
        }
    }
}
