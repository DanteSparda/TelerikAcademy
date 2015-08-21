namespace StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extensions
    {
        public static StringBuilder CustomSubString(this string str, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (str.Length < index + 1)
            {
                throw new ArgumentException("Index was out of range!");
            }
            else if (str.Length - index < length)
            {
                throw new ArgumentException("Length was out of range!");
            }

            for (int i = index; i <= length; i++)
            {
                result.Append(str[i]);
            }

            return result;
        }
    }
}
