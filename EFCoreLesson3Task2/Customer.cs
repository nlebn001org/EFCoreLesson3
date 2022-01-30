using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task2
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();    
    }
}
