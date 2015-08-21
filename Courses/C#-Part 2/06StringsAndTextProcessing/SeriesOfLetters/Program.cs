using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            Console.WriteLine("Result -> {0}\n", ReplaceSequenceWithOneElement(sequence));
        }

        static string ReplaceSequenceWithOneElement(string str)
        {
            string result = str[0].ToString();
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != result[result.Length - 1])
                {
                    result += str[i];
                }
            }

            return result;
        }
    }