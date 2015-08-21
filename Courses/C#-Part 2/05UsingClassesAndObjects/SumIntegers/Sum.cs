using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class Sum
    {
        static void Main()
        {
            Console.WriteLine("Enter your numbers seperated by space");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int[] intArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                intArr[i] = int.Parse(arr[i]);
            }
            Console.WriteLine(intArr.Sum());
        }
    }
}
