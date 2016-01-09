namespace RandomTotoCombinationGenerator
{
    using System;

    public static class RandomNumberGenerator
    {
        private enum Zodiacs
        {
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }

        // The Random class has the max range - 1 !!!
        public static int RandNumber(int startRange, int endRangeMinusOne)
        {
            Random randomNumber = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
            int rnd = randomNumber.Next(startRange, endRangeMinusOne + 1);
            return rnd;
        }

        public static string RandomZodiac()
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int randomZodiac = rndNum.Next(0, 12);
            var zodiac = (Zodiacs)randomZodiac;
            return zodiac.ToString();
        }
    }
}
