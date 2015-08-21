using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class ReplaceSS
{
    static void Main()
    {
        var reader = new StreamReader("..\\..\\input.txt");
        string[] input = reader.ReadToEnd().Split(' ');
        reader.Close();
        List<string> result = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            string currentWord = input[i];
           
                if (currentWord.Length>=4)
                {
                    string prefix = currentWord.Substring(0, 4);
                    if (prefix != "test")
                    {
                        result.Add(currentWord);
                    }
                }
                else
                {
                    result.Add(currentWord);
                }
                
            
        }
        string done = string.Join(" ", result);
        var writer = new StreamWriter("..\\..\\result.txt");
        using (writer)
        {
            if (done != null)
            {
                writer.WriteLine(done);
            }

        }

    }
}
