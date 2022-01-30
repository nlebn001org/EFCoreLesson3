using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task1
{
    internal class Auto
    {
        public int AutoID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public int ManID { get; set; }
        public Man Man { get; set; }
    }
}
