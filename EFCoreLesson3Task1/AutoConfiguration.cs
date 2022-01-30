using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task1
{
    internal class AutoConfiguration : IEntityTypeConfiguration<Auto>
    {
        public void Configure(EntityTypeBuilder<Auto> builder)
        {
            builder.HasKey(a=>a.AutoID);
        }
    }
}
