using System;
    class Larger
    {
        static void Main()
        {
            Console.Write("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ", i);
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the index you desire: ");
            int index = int.Parse(Console.ReadLine());
            foreach (var item in input)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
            string result = isLarger(input,index);
            Console.WriteLine(result);
        }

         static string isLarger(int[] input, int i )
        {
             string result = "it isn't bigger";
            if (i>input.Length)
            {
                Console.WriteLine("i is larger than the array length");
                return "Error"; ;
            }
            if (i==input.Length-1)
            {
                if (input[i] > input[i-1])
                {
                    result = "is bigger";
                }
            }
            if (i<input.Length-1)
            {
                if (input[i] > input[i - 1] && input[i]>input[i+1])
                {
                    result = "is bigger";
                }
            }
            
            return result ;
        }
    }

