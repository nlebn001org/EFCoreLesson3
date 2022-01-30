using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLesson3Task1
{
    internal class Context : DbContext
    {
        public DbSet<Auto> Cars { get; set; } = null!;
        public DbSet<Man> Men { get; set; } = null!;
        public Context() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=Lesson3Task1DB;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ManConfiguration());
            modelBuilder.ApplyConfiguration(new AutoConfiguration());
        }
    }
}
