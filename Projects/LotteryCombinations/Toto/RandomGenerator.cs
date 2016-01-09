namespace Toto
{
    using System;
    using System.Collections.Generic;

    public class RandomGenerator : IRandomGenerator
    {
        Random random = new Random();
        public List<string> GetRandomCombination(int numberOfSymbuls, int maxRange, bool special)
        {
            var resultList = new List<string>();

            if (special)
            {
                resultList.Add(this.Zodiac());
                numberOfSymbuls += 1;
            }

            while (resultList.Count != numberOfSymbuls)
            {
                var numberToAdd = random.Next(1, maxRange + 1).ToString();
                if (!resultList.Contains(numberToAdd))
                {
                    resultList.Add(numberToAdd.ToString());
                }
            }

            resultList.Sort();
            return resultList;
        }

        public string Zodiac()
        {
            int randomZodiac = random.Next(1, 13);
            var zodiac = (ZodiacsType)randomZodiac;
            return zodiac.ToString();
        }
    }
}
