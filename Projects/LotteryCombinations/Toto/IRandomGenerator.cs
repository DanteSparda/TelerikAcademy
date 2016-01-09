namespace Toto
{
    using System.Collections.Generic;

    internal interface IRandomGenerator
    {
         List<string> GetRandomCombination(int numberOfSymbuls, int maxRange, bool special);
        string Zodiac();
    }
}