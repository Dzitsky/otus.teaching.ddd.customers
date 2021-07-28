using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Otus.Teaching.Ddd.Customers.Domain.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task<Guid> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entityId);
    }
}
