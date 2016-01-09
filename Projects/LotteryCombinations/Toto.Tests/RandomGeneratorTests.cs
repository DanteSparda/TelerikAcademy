namespace Toto.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class RandomGeneratorTests
    {
        RandomGenerator randomGenerator = new RandomGenerator();
        [TestMethod]
        public void GetRandomCombinationShouldReturnProperAmountOfNumbersWithoutZodiac()
        {
            var actual = randomGenerator.GetRandomCombination(10, 3, false);
            var expected = 10;
            Assert.AreEqual(actual.Count, expected);
        }

        [TestMethod]
        public void GetRandomCombinationShouldReturnProperAmountOfNumbersWithZodiac()
        {
            var actual = randomGenerator.GetRandomCombination(10, 3, true);
            var expected = 11;
            Assert.AreEqual(actual.Count, expected);
        }

        [TestMethod]
        public void GetRandomCombinationShouldReturnUniqueRandomValues()
        {
            var checkList = new List<string>();
            for (int i = 1; i <= 30; i++)
            {
                checkList.Add(i.ToString());
            }

            var actual = randomGenerator.GetRandomCombination(29, 30, false);

            foreach (var number in actual)
            {
                Assert.IsTrue(checkList.Contains(number));
                checkList.Remove(number);
            }

            Assert.IsTrue(checkList.Count == 1);
        }

        [TestMethod]
        public void GetRandomCombinationShouldReturnZodiacCorreclty()
        {
            var zodiacList = new List<string> {
                                     "Aries",
                                     "Taurus",
                                     "Gemini",
                                     "Cancer",
                                     "Leo",
                                     "Virgo",
                                     "Libra",
                                     "Scorpio",
                                     "Sagittarius",
                                     "Capricorn",
                                     "Aquarius",
                                     "Pisces"};

            for (int i = 0; i < 30; i++)
            {
                var actual = randomGenerator.GetRandomCombination(5, 10, true);
                var zodiac = actual.Select(x => x).Where(x => x.Length > 2).FirstOrDefault().ToString();

                Assert.IsTrue(zodiacList.Contains(zodiac));
            }
        }
    }
}
