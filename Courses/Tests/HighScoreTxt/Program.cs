using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Text;

namespace HighScoreTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> highscores = new List<string>();
            Stopwatch clock = new Stopwatch();
           clock.Start();
           Console.ReadLine();
           clock.Stop();
           var builder = new StringBuilder();
           builder.AppendFormat("{0:D2}:{1:D2}:{2:D2}", clock.Elapsed.Minutes, clock.Elapsed.Seconds, clock.Elapsed.Milliseconds);
           Console.WriteLine(builder);
            var highscoreReader = new StreamReader("..\\..\\..\\Highscores.txt");
            using(highscoreReader)
	        {
                for (int i = 0; i < 10; i++)
                {
                    string currentLine = highscoreReader.ReadLine();
                    highscores.Add(currentLine);
                }
                
	        }
            string currentResult = builder.ToString();
            highscores.Add(currentResult);
            highscores.Sort();
            highscores.Reverse();
            highscores.RemoveAt(10);
            var highscoreWriter = new StreamWriter("..\\..\\..\\Highscores.txt");
            using (highscoreWriter)
            {
                foreach (var scores in highscores)
                {
                    highscoreWriter.WriteLine("{0:00:00}",scores);
                }
            }
            string[] result = File.ReadAllLines("..\\..\\..\\Highscores.txt");
            Console.WriteLine();
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
