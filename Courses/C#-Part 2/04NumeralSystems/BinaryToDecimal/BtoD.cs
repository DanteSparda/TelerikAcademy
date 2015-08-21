using System;
    class BtoD
    {
        static void Main()
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
            Console.WriteLine("In decimal: {0}",sum);

        }
    }

