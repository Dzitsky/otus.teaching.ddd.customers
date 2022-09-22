using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;

namespace Otus.Teaching.Ddd.Customers.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();

        Task<Customer> GetByIdAsync(Guid id);

        Task AddAsync(Customer entity);

        Task UpdateAsync(Customer entity);

        Task DeleteAsync(Guid entityId);
    }
}
