using CoreEF.Models;
using FrameworkEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEF
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-DCDS0CVH;Database=SchoolDBCore;Trusted_Connection=True;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne<Address>(s => s.Address).WithOne(s => s.Student);
        }

    }
}
