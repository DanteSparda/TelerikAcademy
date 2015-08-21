using System;
    class Digit
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
           string result =  returnDigit(n);
           Console.WriteLine(result);
        }
        static string returnDigit(int input)
        {
            int digit = input%10;
            string result = "a" ;
            switch (digit)
	{               case 0: result="zero";
                      break;
                    case 1: result="one";
                      break;
                    case 2: result="two";
                      break;
                    case 3: result="three";
                      break;
                    case 4: result="four";
                      break;
                    case 5: result="five";
                      break;
                    case 6: result="six";
                      break;
                    case 7: result="seven";
                      break;
                    case 8: result="eight";
                      break;
                    case 9: result="nine";
                      break;
            		default: result = "Error";
                      break;
	}
                        return result;
        }
    }

