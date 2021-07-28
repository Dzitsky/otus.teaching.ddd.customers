using System.Collections.Generic;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;

namespace Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess.DbInitialization
{
    public class DropAndCreateDbInitializer
        : IDbInitializer
    {
        private readonly DataContext _dbContext;

        public DropAndCreateDbInitializer(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Initialize()
        {
            this._dbContext.Database.EnsureDeleted();
            this._dbContext.Database.EnsureCreated();

            var customers = new List<Customer>()
            {

            };

            this._dbContext.Customers.AddRange(customers);

            this._dbContext.SaveChanges();
        }
    }
}
