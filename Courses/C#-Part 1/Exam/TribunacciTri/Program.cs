using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


    class Program
    {
        static void Main()
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger rows = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber+" "+thirdNumber);

            for (BigInteger i = 2; i < rows; i++)
            {
                for (BigInteger j = 0; j <= i; j++)
                {
                    BigInteger result = firstNumber + secondNumber + thirdNumber;
                    Console.Write(result+" ");
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = result;
                }
                Console.WriteLine();
                
            }
        }

    }

