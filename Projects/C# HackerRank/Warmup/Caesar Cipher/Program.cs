using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
           // Console.WriteLine((char)98 +" "+ (int) 'a' );
            var stringLength = int.Parse(Console.ReadLine());
            var stringToEncrypt = Console.ReadLine();
            var rotationCode = int.Parse(Console.ReadLine());
            var result = "";
           for (int i = 0; i < stringLength; i++)
           {
               var currChar = stringToEncrypt[i];
               var isUpper = char.IsUpper(currChar);
               if (((int)currChar<65 || (int)currChar>90) && ((int)currChar<97 || (int)currChar>122))
               {
                   result += currChar;
                   continue;
               }
               var newChar = (int)currChar;
               for (int j = 0; j < rotationCode; j++)
               {
                   newChar += 1;
                   if (isUpper && newChar>90)
                   {
                       newChar = 65;
                   }
                   else if (newChar>122)
                   {
                       newChar = 97;
                   }
               }
               result+= (char)newChar;
           }
           Console.WriteLine(result);
        }
    }
}
