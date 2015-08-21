using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Sorting
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
            int min = inputIntArray[0];
            int index = 0;
            bool change = false;
            for (int i = 0; i < inputString.Length; i++)    
            {     
                min = inputIntArray[i];
                for (int j   = i; j < inputString.Length; j++)
                {
                    if (min>inputIntArray[j])
                    {
                        min = inputIntArray[j];
                        index = j;
                        change = true;
                       
                    }
  
                }
                if (change == true)
                {
                 int tmp = inputIntArray[i];
                inputIntArray[i] = min;
                inputIntArray[index] = tmp;
                change = false;

                }

            }
            foreach (var number in inputIntArray)
            {
                Console.Write(number+" ");
            }


        }

    }

