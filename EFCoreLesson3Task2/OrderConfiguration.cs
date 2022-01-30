using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task2
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => new { o.CustomerID, o.OrderDetailID });
            builder.HasOne(o => o.Customer).WithMany(o => o.Orders).HasForeignKey(o => o.CustomerID);
            builder.HasOne(o => o.OrderDetail).WithMany(o => o.Orders).HasForeignKey(o => o.OrderDetailID);
            builder.Property(o => o.OrderDate).HasComputedColumnSql<DateTime>("getdate()");
        }
    }
}
