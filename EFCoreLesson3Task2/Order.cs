using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task2
{
    internal class Order
    {
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int OrderDetailID { get; set; }
        public OrderDetail OrderDetail { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
