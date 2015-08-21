using System;
    class LargerThanNeighbours
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
            foreach (var item in input)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int result = isLarger(input);
            Console.WriteLine("The index is: {0}",result);
        }

        static int isLarger(int[] input)
        {
            int result = -1;
            int index = 0;
            for (int element = 0; element < input.Length; element++)
            {
                if (element==0)
                {
                    if (input[element]>input[element+1])
                    {
                        result = element;
                        break;
                    }
                }
                else if (element!=input.Length-1)
                {
                    if (input[element] > input[element + 1] && input[element]>input[element-1])
                    {
                        result = element;
                        break;
                    }
                }
                else
                {
                    if (input[element] > input[element - 1])
                    {
                        result = element;
                        break;
                    }
                }
                

            }

            return result;
        }
    }

