using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Problem 9. Frequent number

Write a program that finds the most frequent number in an array. */ 
namespace FrequentNumber
{
    class Frequent
    {
        static void Main()
        {
            Console.WriteLine("Enter the array (numbers separated by space)");
            string input = Console.ReadLine();
            input = input.Replace(",", "").Trim();
            string[] inputString = input.Split(' ');
            int[] inputIntArray = new int[inputString.Length];
            int[] result = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                inputIntArray[i] = int.Parse(inputString[i]);
            }
            Array.Sort(inputIntArray);
            int currentCounter = 0;
            int currentNumber = inputIntArray[0];
            int freqCounter = 0;
            int freqNumber = 0;
            for (int i = 0; i < inputIntArray.Length; i++)
            {
                if (currentNumber == inputIntArray[i])
                {
                    currentCounter++;
                }
                else
                {
                  
                    if (freqCounter < currentCounter)
                    {
                        freqCounter = currentCounter;
                        freqNumber = currentNumber;
                    }
                    currentCounter = 1;
                    currentNumber = inputIntArray[i];

                }
                
            }
            if (freqCounter < currentCounter)
            {
                freqCounter = currentCounter;
                freqNumber = currentNumber;
            }
            Console.WriteLine("{0}({1} times)", freqNumber, freqCounter);
        }
    }
}
