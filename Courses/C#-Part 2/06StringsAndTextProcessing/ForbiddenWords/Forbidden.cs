using System;
using System.Collections.Generic;
using System.Text;
class Forbidden
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        List<string> forbiddenWords = new List<string>();
        forbiddenWords.Add("PHP"); forbiddenWords.Add("Microsoft"); forbiddenWords.Add("CLR");
        for (int i = 0; i < forbiddenWords.Count; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }

      
        Console.WriteLine(text);
    }
}
