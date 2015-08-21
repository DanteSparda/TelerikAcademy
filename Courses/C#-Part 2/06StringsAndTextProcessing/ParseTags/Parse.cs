using System;
using System.Text;
class Parse
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>." +
            " We don't have <upcase>anything</upcase> else.";

        bool inText = true;
        bool inOpenTag = false;
        bool inBetweenTags = false;
        bool inClosingTags = false;

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char currentSymbol = text[i];

            if (inText)
            {
                if (currentSymbol == '<')
                {
                    inText = false;
                    inOpenTag = true;
                }
                else
                {
                    output.Append(currentSymbol);
                }
            }
            else if (inOpenTag)
            {
                if (currentSymbol == '>')
                {
                    inBetweenTags = true;
                    inOpenTag = false;
                }
            }
            else if (inBetweenTags)
            {
                if (currentSymbol == '<')
                {
                    inBetweenTags = false;
                    if (text[i + 1] == '/')
                    {
                        inClosingTags = true;
                    }
                    else
                    {
                        inOpenTag = true;
                    }
                }
                else
                {
                    output.Append(currentSymbol.ToString().ToUpper());
                }
            }
            else if (inClosingTags)
            {
                if (currentSymbol == '>')
                {
                    inText = true;
                    inClosingTags = false;
                }
            }
        }

        Console.WriteLine(output.ToString());
    }

}

