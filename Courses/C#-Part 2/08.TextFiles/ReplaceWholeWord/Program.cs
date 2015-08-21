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
        string deletedWord = "start";
        string newWord = "finish";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]==deletedWord)
            {
                input[i] = newWord;
            }
        }
        string result = string.Join(" ", input);
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
