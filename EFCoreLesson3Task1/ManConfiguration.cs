using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task1
{
    internal class ManConfiguration : IEntityTypeConfiguration<Man>
    {
        public void Configure(EntityTypeBuilder<Man> builder)
        {
            builder.HasKey(m => m.ManID);
            builder.HasMany(m => m.Cars).WithOne(a => a.Man).HasForeignKey(a => a.ManID);
        }
    }
}
