using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;
using Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess;
using Otus.Teaching.Ddd.Customers.Domain.Repositories;

namespace Otus.Teaching.Ddd.Customers.Infrastructure.Repositories
{
    public class EfCustomerRepository
        : ICustomerRepository
    {
        private readonly DataContext _dbContext;

        public EfCustomerRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await this
                ._dbContext
                .Customers
                .Include(x => x.JobPlaces)
                .Include(x => x.Contacts)
                .ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            return await this.
                _dbContext
                .Customers
                .Include(x => x.JobPlaces)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Customer entity)
        {
            await this._dbContext.Customers.AddAsync(entity);

            await this._dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer entity)
        {
            this._dbContext.Customers.Update(entity);

            await this._dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid entityId)
        {
            var entity = await this._dbContext.Customers.SingleOrDefaultAsync(x => x.Id == entityId);

            this._dbContext.Customers.Remove(entity);

            await this._dbContext.SaveChangesAsync();
        }
    }
}
