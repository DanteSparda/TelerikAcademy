using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateTextFiles
{
    class Concatenate
    {
        static void extractingWords(List<string> list,StreamReader reader)
        {
            using (reader)
            {
                string currentWord = reader.ReadLine();
                while (currentWord != null)
                {
                    list.Add(currentWord);
                    currentWord = reader.ReadLine();
                }
            }
        }
        static void fillingTheResult(List<string> firstList, List<string> secondList, StreamWriter writer)
        {
            string input = "a";
            using (writer)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    input = string.Concat(firstList[i], secondList[i]);
                    writer.WriteLine(input);
                }
            }
           
                
            
        }
        static void Main()
        {
           var readerOne = new StreamReader("..\\..\\FirstFile.txt");
           var readerTwo = new StreamReader("..\\..\\SecondFile.txt");
            var writer = new StreamWriter("..\\..\\Result.txt");
           List<string>firstList = new List<string>();
           List<string> secondList = new List<string>();

           extractingWords(firstList, readerOne);
           extractingWords(secondList, readerTwo);
           fillingTheResult(firstList, secondList, writer);

           var printingResult = new StreamReader("..\\..\\Result.txt");

           string input = printingResult.ReadLine();
           while (input!=null)
           {
               Console.WriteLine(input);
               input = printingResult.ReadLine();
           }


          
          
           
          

        }
    }
}
