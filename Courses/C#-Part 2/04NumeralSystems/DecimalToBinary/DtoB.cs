using System;
    class DtoB
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int input = int.Parse(Console.ReadLine());
            string result = "";
            do
            {
                int remainder = input % 2;
                if (remainder==1)
                {
                   result+="1";
                }
                else
                {
                    result+="0";
                }
                input /= 2;
            } while (input!=0);
          char[] arr =   result.ToCharArray();
            Array.Reverse(arr);
            string finalResult = string.Join("", arr);
            Console.WriteLine("In binary: {0}",finalResult);
        }
    }

