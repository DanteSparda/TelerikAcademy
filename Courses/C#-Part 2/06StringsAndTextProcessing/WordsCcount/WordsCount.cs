using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class WordsCount
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            MatchCollection words = Regex.Matches(str, @"\b\w+\b");
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word.ToString()))
                {
                    dict.Add(word.ToString(), 1);
                }
                else
                {
                    dict[word.ToString()]++;
                }
            }

            Console.WriteLine("\nWord occurence table:\n{0}\n",
                string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
        }
    }

