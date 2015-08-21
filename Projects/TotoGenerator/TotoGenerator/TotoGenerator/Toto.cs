using System.Text.RegularExpressions;

namespace RandomTotoCombinationGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Toto
    {
        public static int RandNumber(int low, int high)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(low, high);

            return rnd;
        }
        public static string TotoGenerator(int maxRange)
        {
            //TODO: Add the numbers from Lost (4,8,15,16,23,42)
            if (maxRange != 49 && maxRange != 42)
            {
                throw new ArgumentException("Max range is either 42 or 49");
            }
            var totoNumbers = new StringBuilder();
            var notDuplicatedNumbers = new List<int>();
           while (notDuplicatedNumbers.Count < 6)
           {
               var randomNumber = RandNumber(1, maxRange + 1);
               if (!notDuplicatedNumbers.Contains(randomNumber))
               {
                   notDuplicatedNumbers.Add(randomNumber);
               }
           }

            notDuplicatedNumbers.Sort();
            notDuplicatedNumbers.ForEach(x => totoNumbers.Append("[" + x + "] "));
            return totoNumbers.ToString();
        }
        private static void Main()
        {
            var numbers =  new List<string>
            {
                "3",
                "123",
                "92",
                "33", "Libra"
            };
            Console.WriteLine(numbers[numbers.Count-1]);

            var exit = "yes";
            while (exit != "no")
            {
                Console.WriteLine("Enter max range:");
                int totoMaxRange = int.Parse(Console.ReadLine());
                Console.WriteLine(TotoGenerator(totoMaxRange));
                Console.WriteLine("Try again? Write \"no\" if not");
                exit = Console.ReadLine().ToLower();
                Console.Clear();
            }
            
        }
    }
}

