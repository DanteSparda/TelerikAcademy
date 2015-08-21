using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTextFiles
{
    class Compare
    {
        static void Main()
        {
            var readerOne = new StreamReader("..\\..\\FirstFile.txt");
            var readerTwo = new StreamReader("..\\..\\SecondFile.txt");
            List<string> collectionOne = new List<string>();
            List<string> collectionTwo = new List<string>();
            using (readerOne)
            {
                string textLine = readerOne.ReadLine();
                while (textLine != null)
                {
                    collectionOne.Add(textLine);
                    textLine = readerOne.ReadLine();
                }
            }
            using (readerTwo)
            {
                string textLine = readerTwo.ReadLine();
                while (textLine != null)
                {
                    collectionTwo.Add(textLine);
                    textLine = readerTwo.ReadLine();
                }
            }
            int different = 0;
            int same = 0;
            for (int i = 0; i < collectionOne.Count; i++)
            {
                if (collectionOne[i]==collectionTwo[i])
                {
                    same++;
                }
                else
                {
                    different++;
                }
            }
            Console.WriteLine("There are {0} same lanes and {1} different ones",same,different);
        }
    }
}
