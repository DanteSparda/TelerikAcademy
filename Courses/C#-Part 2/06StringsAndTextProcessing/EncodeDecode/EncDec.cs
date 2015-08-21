using System;
using System.Text;
    class EncDec
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter cipher");
            string cipher = Console.ReadLine();
           StringBuilder encoded =  Encode(input, cipher);
           StringBuilder decoded = Decode(encoded, cipher);
            Console.WriteLine(encoded);
            Console.WriteLine(decoded);
        }

        static StringBuilder Encode(string input, string cipher)
        {
            StringBuilder result = new StringBuilder();
            int cipherLength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] ^ cipher[cipherLength]));
                cipherLength++;
                if (cipherLength > cipher.Length - 1)
                {
                    cipherLength = 0;
                }
            }
            return result;
        }
        static StringBuilder Decode(StringBuilder input, string cipher)
        {
            StringBuilder result = new StringBuilder();
            int cipherLength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] ^ cipher[cipherLength]));
                cipherLength++;
                if (cipherLength > cipher.Length - 1)
                {
                    cipherLength = 0;
                }
            }
            return result;
        }
    }

