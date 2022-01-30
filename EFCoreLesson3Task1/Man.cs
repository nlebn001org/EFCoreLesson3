using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task1
{
    internal class Man
    {
        public int ManID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Auto> Cars { get; set; }
    }
}
