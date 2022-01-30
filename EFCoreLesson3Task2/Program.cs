using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCoreLesson3Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { Name = "Oleg" };
            Customer c2 = new Customer() { Name = "Rob" };
            Customer c3 = new Customer() { Name = "Dan" };
            OrderDetail od1 = new OrderDetail() { Qty = 3, PricePerProd = 12 };
            OrderDetail od2 = new OrderDetail() { Qty = 4, PricePerProd = 20 };
            OrderDetail od3 = new OrderDetail() { Qty = 2, PricePerProd = 15 };
            Order o1 = new Order() { Customer = c1, OrderDetail = od2 };
            Order o2 = new Order() { Customer = c1, OrderDetail = od1 };
            Order o3 = new Order() { Customer = c1, OrderDetail = od3 };
            Order o4 = new Order() { Customer = c2, OrderDetail = od1 };

            using (Context db = new Context())
            {
                db.Orders.AddRange(o1, o2, o3, o4);
                db.SaveChanges();

                List<Order> orders = db.Orders.Include(o => o.Customer).Include(o => o.OrderDetail).ToList();

                foreach (Order o in orders)
                {
                    Console.WriteLine($"Customer: {o.Customer.Name}, Quantity: {o.OrderDetail.Qty}, PricePerProd: {o.OrderDetail.PricePerProd}, " +
                        $"Sum: {o.OrderDetail.Sum}, Date: {o.OrderDate}");
                }
            }
        }
    }
}
