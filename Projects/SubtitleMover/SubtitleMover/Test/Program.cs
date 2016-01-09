using SubtitleMover.EngineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var mover = new SubMover(@"C:\Downloads\Friends.S07.UNCUT.DVDRip.XviD-SAiNTS");
            var response = mover.MoveSubtitlesToDirectories();

            if (response.HasMoved)
            {
                Console.WriteLine("Total: {0} files have been moved!", response.Count);
            }
            else if(!response.FoundSubs)
            {
                Console.WriteLine("No subtitles found");
            }
            else if (!response.HasMoved)
            {
                Console.WriteLine("No subtitles were moved");
            }
            Console.ReadLine();
        }
    }
}