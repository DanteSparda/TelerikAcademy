using System;
    class GetLargest
    {
        static void Main()
        {
            int[] input = new int[3];
            for (int i = 0; i < 3; i++)
            {
                   Console.Write("Enter number N{0} :",i+1);
                   input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(GetMax(input[0], GetMax(input[1], input[2])));
         
        }
        static int GetMax(int first,int second)
        {
            int max = Math.Max(first, second);
            return max;
        }
    }

