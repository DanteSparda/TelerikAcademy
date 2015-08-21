namespace RandomTotoCombinationGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Toto
    {
        public static List<string> TotoGenerator(int maxRange)
        {
            // TODO: Add the numbers from Lost (4,8,15,16,23,42)
            if (maxRange != 49 && maxRange != 50 && maxRange != 42 && maxRange != 35)
            {
                throw new ArgumentOutOfRangeException("Toto games upper range is 35, 42, 49 and 59 to date 15.08.2015!");
            }

            var numbers = new List<string>();
            GenerateNumers(numbers, maxRange);

            return numbers;
        }

        private static void SortNumbers(List<string> numbers)
        {
            var intList = new List<int>();
            if (Regex.IsMatch(numbers[numbers.Count - 1], @"^\d+$"))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    intList.Add(int.Parse(numbers[i]));
                }

                numbers.Clear();
                intList.Sort();
                for (int i = 0; i < intList.Count; i++)
                {
                    numbers.Add(intList[i].ToString());
                }
            }
            else
            {
                var zodiac = numbers[numbers.Count - 1];
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    intList.Add(int.Parse(numbers[i]));
                }

                numbers.Clear();
                intList.Sort();

                for (int i = 0; i < intList.Count; i++)
                {
                    numbers.Add(intList[i].ToString());
                }

                numbers.Add(zodiac);
            }
        }

        private static void GenerateNumers(List<string> numbers, int maxRange)
        {
            numbers.Clear();

            var randomNumber = string.Empty;
            var numbersInDraw = 0;

            if (maxRange == 49 || maxRange == 42)
            {
                numbersInDraw = 6;
            }
            else if (maxRange == 50 || maxRange == 35)
            {
                numbersInDraw = 5;
            }

            while (numbers.Count < numbersInDraw)
            {
                randomNumber = RandomNumberGenerator.RandNumber(1, maxRange).ToString();
                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

            // Zodiac exception
            if (maxRange == 50)
            {
                var zodiac = RandomNumberGenerator.RandomZodiac();
                numbers.Add(zodiac);
            }

            SortNumbers(numbers);
        }
    }
}