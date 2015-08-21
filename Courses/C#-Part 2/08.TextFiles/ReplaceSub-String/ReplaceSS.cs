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
        string input = reader.ReadToEnd();
        reader.Close();
        string deletedWord = "start";
        string newWord = "finish";
        string result = input.Replace(deletedWord, newWord);
        var writer = new StreamWriter("..\\..\\result.txt");
        using (writer)
        {
            if (result != null)
            {
                writer.WriteLine(result);
            }

        }

    }
}
