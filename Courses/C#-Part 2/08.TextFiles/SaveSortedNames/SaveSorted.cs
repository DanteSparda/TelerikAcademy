using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSortedNames
{
    class SaveSorted
    {
        static void Main()
        {
            var reader = new StreamReader("..\\..\\input.txt");
            string currentName = reader.ReadLine();
            List<string> collection = new List<string>();
            using (reader)
            {
                while (currentName != null)
                {
                    collection.Add(currentName);
                    currentName = reader.ReadLine();
                }
            }
            collection.Sort();
            var writer = new StreamWriter("..\\..\\output.txt");
            using (writer)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    writer.WriteLine(collection[i]);
                }
            }
           

           
        }
    }
}
