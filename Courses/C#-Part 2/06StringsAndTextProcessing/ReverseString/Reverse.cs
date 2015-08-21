using System;
    class Reverse
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string result = string.Join("",arr);
            Console.WriteLine(result);
        }
    }
