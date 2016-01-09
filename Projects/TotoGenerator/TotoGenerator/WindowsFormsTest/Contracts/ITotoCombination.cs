using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTotoCombinationGenerator.Contracts
{
    interface ITotoCombination
    {
         int MaxRange { get; set; }
         bool HasZodiac { get; set; }
         int NumberOfNumbersInCombination { get; set; }
    }
}
