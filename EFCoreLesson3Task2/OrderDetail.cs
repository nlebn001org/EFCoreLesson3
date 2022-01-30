using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task2
{
    internal class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int Qty { get; set; }
        public decimal PricePerProd { get; set; }
        public decimal Sum { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>(); 
    }
}
