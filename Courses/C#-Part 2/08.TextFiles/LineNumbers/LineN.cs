using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineN
    {
        static void Main()
        {
            var reader = new StreamReader("..\\..\\input.txt");
            var writer = new StreamWriter("..\\..\\output.txt");
            List<string> collection = new List<string>();
            using (reader)
            {
                string textLine = reader.ReadLine();
                while (textLine!=null)
                {
                    collection.Add(textLine);
                    textLine = reader.ReadLine();
                }
                
            }
            using (writer)
            {
                for (int i = 1; i <= collection.Count; i++)
                {
                    writer.WriteLine("{0:D2}. {1}", i, collection[i-1]);
                }
            }

        }
    }
}
