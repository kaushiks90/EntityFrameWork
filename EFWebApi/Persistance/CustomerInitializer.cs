using CoreEF.Models;
using EFCoreWebApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.CustomerInitializer.Persistance
{
    public class CustomerInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customers.Any())
            {
                return;
            }

            Seed(context);
        }

        private static void Seed(CustomerContext context)
        {
            var customers = new[]
            {
                new Customer { Name = "Jerry Smith" },
                new Customer { Name = "Summer Smith" },
                new Customer { Name = "Morty Smith" },
                new Customer { Name = "Rick Sanchez" },
                new Customer { Name = "Beth Smith" },
                new Customer { Name = "Mr. Meeseeks" },
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}
