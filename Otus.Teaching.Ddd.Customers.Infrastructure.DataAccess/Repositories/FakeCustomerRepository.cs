using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;
using Otus.Teaching.Ddd.Customers.Domain.Repositories;


namespace Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess.Repositories
{
    public class FakeCustomerRepository
        : ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}
