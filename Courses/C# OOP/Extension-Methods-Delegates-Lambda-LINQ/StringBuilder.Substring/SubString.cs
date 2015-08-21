namespace StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class SubString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder testing = input.CustomSubString(1, 13);
            Console.WriteLine(testing);
        }
    }
}
