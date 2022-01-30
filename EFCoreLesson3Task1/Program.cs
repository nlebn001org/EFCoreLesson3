using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCoreLesson3Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man1 = new Man() { Name = "Name1", Surname = "Surname1" };
            Man man2 = new Man() { Name = "Name2", Surname = "Surname2" };
            Auto a1 = new Auto() { Brand = "Brand1", Model = "Model1", Man = man1 };
            Auto a2 = new Auto() { Brand = "Brand2", Model = "Model2", Man = man1 };
            Auto a3 = new Auto() { Brand = "Brand3", Model = "Model3", Man = man2 };
            Auto a4 = new Auto() { Brand = "Brand4", Model = "Model4", Man = man2 };
            Auto a5 = new Auto() { Brand = "Brand5", Model = "Model5", Man = man1 };

            using (Context db = new Context())
            {
                db.Cars.AddRange(a1, a2, a3, a4, a5);
                db.SaveChanges();

                List<Auto> cars = db.Cars.Include(a => a.Man).ToList();

                foreach (Auto car in cars)
                    Console.WriteLine($"Man: {car.Man.Name}, Brand: {car.Brand}, Model: {car.Model}");


            }
        }
    }
}
