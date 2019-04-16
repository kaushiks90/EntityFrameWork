using CoreEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.Persistance
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerContext() { }

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDb;Database=Northwind777;Trusted_Connection=True;");
            }
        }
    }
}
