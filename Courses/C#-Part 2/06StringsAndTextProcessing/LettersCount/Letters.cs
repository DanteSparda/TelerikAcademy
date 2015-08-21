using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Letters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] inputArr = input.ToCharArray();
        var inputList = new List<char>(inputArr);
        int count = 0;
        inputList.Sort();

        while (Char.IsLetter(inputList[0]) == false)
        {
            inputList.RemoveAt(0);
            try
            {
                Char.IsLetter(inputList[0]);

            }
            catch (Exception)
            {

                Console.WriteLine("There are no letters!");
                break;
            }
        }
        int counter = 1;
        char currentLetter = ' ';

        try
        {
            currentLetter = inputList[0];
        }
        catch (Exception)
        {

            Console.WriteLine("Try again!");
        }
        inputList.Add(' ');
        for (int i = 0; i < inputList.Count; i++)
        {
            if (i == inputList.Count - 1)
            {
                if (currentLetter != inputList[i])
                {
                    Console.WriteLine("{0} -> {1} times", currentLetter, counter);
                    currentLetter = inputList[i + 1];
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
            else
            {
                if (currentLetter != inputList[i + 1])
                {
                    Console.WriteLine("{0} -> {1} times", currentLetter, counter);
                    currentLetter = inputList[i + 1];
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}

