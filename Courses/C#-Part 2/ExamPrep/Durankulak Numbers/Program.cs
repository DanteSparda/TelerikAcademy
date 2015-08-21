using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class Program
{
    private static Dictionary<string, int> collection = new Dictionary<string, int>();
    private static string current = "";
    private static int powers = -1;
    static void Main(string[] args)
    {
        Dict();
        string input = Console.ReadLine();
   
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i])) powers++;
        }
        BigInteger result = 0 ;
        for (int i = 0; i < input.Length; i++)
        {

            if (char.IsLower(input[i]))
            {
                current +=input[i];
                current += input[i+1];
                i++;
            }
            else
            {
                current += input[i];
            }
             result += Magic(current);
            powers--;
            current = "";
        }
        Console.WriteLine(result);

    }
    static void Dict()
    {
        for (int i = 0; i < 26; i++)
        {
            char bigletter = (char)(65+i);
                string currentAdd = bigletter.ToString();
                collection.Add(currentAdd, i);

        }
        int counter = 26;
        for (int small = 0; small < 6; small++)
        {
            for (int big = 0; big < 26; big++)
            {
                char smallChar = (char)(small + 97) ;
                char bigChar = (char)(big + 65);
                if (smallChar == 'f' && bigChar=='M')
                {
                    return;
                }
                string currentAdd = smallChar.ToString()+bigChar.ToString();
                collection.Add(currentAdd,counter);
                counter++;
                
            }
        }
    }
    static BigInteger Magic(string current)
    {
        int value = collection[current.ToString()];
        BigInteger result = value*Power(powers);
        return result;
    }
    static long Power(int power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 168;
        }
        return result;
    }
}

