using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Treta
{
    class Program
    {
        static void Main()
        {
            BigInteger[] inputArray = new BigInteger[10000];
            List<BigInteger> BigIntList = new List<BigInteger>();
            for (int i = 0; i < 10000; i++)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    BigIntList.Add(BigInteger.Parse(input));
                }
                else
                {
                    break;
                }

            }
            BigInteger odd = 0;
            BigInteger counter = 0;
            BigInteger result = 1;
            foreach (BigInteger number in BigIntList)
            {
                counter++;
                if (odd % 2 != 0)
                {

                    string numberToString = number.ToString();
                    BigInteger miniResult = 1;
                    foreach (char digit in numberToString)
                    {

                        int toNumber = int.Parse(digit.ToString());
                        if (toNumber == 0)
                        {
                            continue;
                        }
                        else
                        {
                            miniResult *= toNumber;
                        }



                    }
                    result *= miniResult;
                }
                if (counter == 10)
                {
                    Console.WriteLine(result);
                    result = 1;
                }

                odd++;

            }
            Console.WriteLine(result);
        }
    }
}