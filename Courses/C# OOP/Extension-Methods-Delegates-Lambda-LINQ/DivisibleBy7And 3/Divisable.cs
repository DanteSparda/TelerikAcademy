namespace DivisibleBy7And_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Divisable
    {
        static void Main()
        {
            int[] intArr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 21, 28, 6 * 14 };
            var newArr = intArr.Where(num => num % 7 == 0 && num % 3 == 0);
            foreach (var num in newArr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
