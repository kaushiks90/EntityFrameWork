using EFCoreWebApi.Persistance;
using EFCoreWebApi.Tests.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreWebApi.Tests.Infrastructure
{
    public class CustomerTestBase:IDisposable
    {
        protected readonly CustomerContext _context;

        public CustomerTestBase()
        {
            var options = new DbContextOptionsBuilder<CustomerContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new CustomerContext(options);

            _context.Database.EnsureCreated();

            CustomerInitializer1.Initialize(_context);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();

            _context.Dispose();
        }
    }
}
