using System;
using System.Threading.Tasks;
using Otus.Teaching.Ddd.Customers.Core.Domain.Dto;

namespace Otus.Teaching.Ddd.Customers.Core.Application.Services.Abstractions
{
    public interface ICustomerService
    {
        Task<CustomersForListDto> GetCustomersForListAsync();

        Task<CustomerDto> GetCustomerAsync(Guid id);

        Task<CustomerCreatedDto> CreateCustomerAsync(CreateCustomerDto customerDto);

        Task EditCustomerAsync(EditCustomerDto customerDto);
    }
}
