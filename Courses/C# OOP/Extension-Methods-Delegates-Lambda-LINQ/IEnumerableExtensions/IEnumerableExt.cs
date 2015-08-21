using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class IEnumerableExt
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(12);
            list.Add(1);
            list.Add(2);
            list.Add(32);
            list.Add(1122);
            list.Add(122);
            list.Add(1532);
            list.Add(1215);
            Console.WriteLine(list.MinInCollection());
        }
    }
}
