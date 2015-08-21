using System;
    class BtoH
    {
        static void Main(string[] args)
        {
           double result =  toDecimal();
           toHex(result);
        }
        static double toDecimal()
        {
            Console.Write("Enter your number: ");
            int input = int.Parse(Console.ReadLine());
            int strn = input.ToString().Length;
            double sum = 0;
            for (int i = 0; i < strn; i++)
            {
                int lastDigit = input % 10;
                sum += lastDigit * (Math.Pow(2, i));
                input = input / 10;
            }
            return sum;
        }
        static void toHex(double input)
        {
           string newInput =  input.ToString();
            int decimalNumber = int.Parse(newInput);

            string hexadecimalRepresentation = null;
            while (decimalNumber != 0)
            {
                char character = ' ';
                var remainder = (byte)(decimalNumber % 16);
                if ((remainder >= 0) && (remainder <= 9))
                {
                    switch (remainder)
                    {
                        case 0:
                            character = '0';
                            break;
                        case 1:
                            character = '1';
                            break;
                        case 2:
                            character = '2';
                            break;
                        case 3:
                            character = '3';
                            break;
                        case 4:
                            character = '4';
                            break;
                        case 5:
                            character = '5';
                            break;
                        case 6:
                            character = '6';
                            break;
                        case 7:
                            character = '7';
                            break;
                        case 8:
                            character = '8';
                            break;
                        case 9:
                            character = '9';
                            break;
                    }
                }
                else
                {
                    switch (remainder)
                    {
                        case 10:
                            character = 'A';
                            break;
                        case 11:
                            character = 'B';
                            break;
                        case 12:
                            character = 'C';
                            break;
                        case 13:
                            character = 'D';
                            break;
                        case 14:
                            character = 'E';
                            break;
                        case 15:
                            character = 'F';
                            break;
                    }
                }
                // Save hexadecimal representation
                hexadecimalRepresentation = character + hexadecimalRepresentation;
                decimalNumber = decimalNumber / 16;
            }
            Console.WriteLine("In hexadecimal: {0}", hexadecimalRepresentation);
        }
    }

