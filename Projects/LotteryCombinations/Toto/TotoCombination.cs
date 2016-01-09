namespace Toto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TotoCombination
    {
        private int maxRange;
        private int numberOfCombinations;
        private bool special;

        public TotoCombination(int maxRange, int numberOfCombination, bool special)
        {
            this.maxRange = maxRange;
            this.numberOfCombinations = numberOfCombination;
            this.special = special;
        }

        public List<string> Combination()
        {
            var combination = new RandomGenerator().GetRandomCombination(numberOfCombinations,maxRange,special);
            return combination;
        }
    }
}
