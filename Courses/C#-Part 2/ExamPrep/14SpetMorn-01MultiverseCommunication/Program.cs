using System;
class Program
{
    static int ConvertToDigit(string word)
    {
        int result = 1;
        switch (word)
        {
            case "CHU": result = 0; break;
            case "TEL": result = 1; break;
            case "OFT": result = 2; break;
            case "IVA": result = 3; break;
            case "EMY": result = 4; break;
            case "VNB": result = 5; break;
            case "POQ": result = 6; break;
            case "ERI": result = 7; break;
            case "CAD": result = 8; break;
            case "K-A": result = 9; break;
            case "IIA": result = 10; break;
            case "YLO": result = 11; break;
            case "PLA": result = 12; break;
            default: throw new ArgumentException(); 
                
        }
        return result;
    }
    static long PowerOfThirdteen(int power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 13;
        }
        return result;
    } 
    static void Main()
        {
            
            string input = Console.ReadLine();
            long result = 0;
            int position = input.Length / 3 - 1;
            for (int i = 0; i < input.Length; i+=3)
            {
                string currentWord = input.Substring(i, 3);

                result += ConvertToDigit(currentWord) * PowerOfThirdteen(position);
                position--;
            }
            Console.WriteLine(result);
        }
}

