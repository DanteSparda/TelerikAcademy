using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array. */

    class Letters
    {
        static void Main()
        {
            Console.Write("Enter your word: ");
            string theWord = Console.ReadLine();
            char[] letters = new char[26];
            for (int i = 97,arrayI=0; i < 123; i++,arrayI++)
            {
                letters[arrayI] = (char)i;
            }
            
            for (int i = 0; i < theWord.Length; i++)
            {
                int counter = 0;
                foreach (char letter in letters)
                {
                  
                    if (theWord[i]==letter)
                    {
                        Console.WriteLine("The letter {0} is at index {1} in the array",theWord[i],counter);
                    }
                    counter++;
                }
            }
        }
    }

