using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HtoB
    {
        static void Main()
        {
           int convertor =  hexToDecimal();
           decimalToBinary(convertor);
        }
        static void decimalToBinary(int input)
        {
            string result = "";
            do
            {
                int remainder = input % 2;
                if (remainder == 1)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
                input /= 2;
            } while (input != 0);
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            string finalResult = string.Join("", arr);
            Console.WriteLine("In binary: {0}", finalResult);
        }
        static int hexToDecimal()
        {
            string hexadecimal = Console.ReadLine();
            int decimalNumber = 0;
            int grade = 0;

            for (int i = hexadecimal.Length - 1; i >= 0; i--)
            {
                char symbol = hexadecimal[i];
                int symbolValue = 0;
                if (char.IsNumber(symbol))
                {
                    symbolValue = symbol - '0';
                }
                else
                {
                    switch (symbol)
                    {
                        case 'A': symbolValue = 10; break;
                        case 'B': symbolValue = 11; break;
                        case 'C': symbolValue = 12; break;
                        case 'D': symbolValue = 13; break;
                        case 'E': symbolValue = 14; break;
                        case 'F': symbolValue = 15; break;
                    }
                }
                double currentGrade = Math.Pow(16, grade);
                decimalNumber += (int)currentGrade * symbolValue;
                grade++;
                
            }
            return decimalNumber;
        }

    }
}
