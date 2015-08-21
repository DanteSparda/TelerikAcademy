using System;
/* Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/
    class Product
    {
        static void Main()
        {
            Console.Write("Enter your integers separated by space: ");
            string input  = Console.ReadLine();
            string[] inputInArray = input.Split(' ');
            int[] intArray = new int[inputInArray.Length];
            for (int i = 0; i < inputInArray.Length; i++)
            {
                intArray[i] = int.Parse(inputInArray[i]);
            }
            int evenProduct = 1;
            int oddProduct = 1;
            for (int i = 0; i < inputInArray.Length; i++)
            {
                if (i%2==0)
                {
                    evenProduct *= intArray[i];
                }
                else
                {
                    oddProduct *= intArray[i];
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("odd_product = {0}",evenProduct);
                Console.WriteLine("even_product = {0}",oddProduct);
            }
        }
    }

