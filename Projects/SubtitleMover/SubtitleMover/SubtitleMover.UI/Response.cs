using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitleMover.UI
{
    public class Response
    {
        public int Count { get; set; }
        public bool HasMoved { get; set; }
        public bool FoundSubs { get; set; }
        public bool FoundDirs { get; set; }
        public string Message { get; set; }
    }
}
