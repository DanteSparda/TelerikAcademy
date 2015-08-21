using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
		{
			{".NET", "platform for applications from Microsoft"},
			{"CLR", "managed execution environment for .NET"},
			{"NAMESPACE", "hierarchical organization of classes"}
		};

            Console.WriteLine("Dictionary words: {0}\n", string.Join(", ", dict.Keys));

            Console.Write("Enter a word to see its explanation: ");
            string word = Console.ReadLine().ToUpper();

            Console.WriteLine(dict.ContainsKey(word) ? string.Format("\n{0} -> {1}\n", word, dict[word])
                              : string.Format("\nDictionary does not contain word \"{0}\".\n", word));
        }
    }
}
