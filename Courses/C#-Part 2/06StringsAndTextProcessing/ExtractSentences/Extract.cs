using System;
using System.Text;
    class Extract
    {
        static void Main()
        {
            string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
            So we are drinking all the day. We will move out of it in 5 days.";
            string word = " in ";
            StringBuilder result = new StringBuilder();
            int prevDot = 0;
            int theDot = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int wordIn = text.IndexOf(word, theDot);
                if (wordIn>-1)
                {
                    prevDot = text.LastIndexOf('.', wordIn);
                    theDot = text.IndexOf('.', wordIn);
                    string sentense = text.Substring(prevDot + 1, theDot - prevDot);
                    result.Append(sentense);
                   
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }

