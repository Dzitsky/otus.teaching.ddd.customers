using System;
using System.Linq;
using System.Threading.Tasks;
using Otus.Teaching.Ddd.Customers.Core.Application.Factories;
using Otus.Teaching.Ddd.Customers.Core.Application.Services.Abstractions;
using Otus.Teaching.Ddd.Customers.Core.Domain.Dto;
using Otus.Teaching.Ddd.Customers.Domain.Repositories;

namespace Otus.Teaching.Ddd.Customers.Core.Application.Services
{
    public class CustomerAggregateService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAggregateService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public async Task<CustomersForListDto> GetCustomersForListAsync()
        {
            var customers = await this._customerRepository.GetAllAsync();

            return new CustomersForListDto
            {
                Items = customers.Select(x => new CustomersForListItemDto
                {
                    Email = x.Contacts?.FirstOrDefault()?.Email,
                    Phone = x.Contacts?.FirstOrDefault()?.Phone,
                    Channel = x.Channel.ToString(),
                    CreatedDate = x.CreatedDate.ToString("dd.MM.yyyy"),
                    FullName = x.FullName,
                }).ToList()
            };
        }

        public async Task<CustomerDto> GetCustomerAsync(Guid id)
        {
            var customer = await this._customerRepository.GetByIdAsync(id);

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            return new CustomerDto
            {
                Email = customer.Contacts?.FirstOrDefault()?.Email,
                Phone = customer.Contacts?.FirstOrDefault()?.Phone,
                Channel = customer.Channel.ToString(),
                CreatedDate = customer.CreatedDate.ToString("dd.MM.yyyy"),
                FullName = customer.FullName,
            };
        }

        public async Task<CustomerCreatedDto> CreateCustomerAsync(CreateCustomerDto customerDto)
        {
            if (customerDto == null)
            {
                throw new ArgumentNullException(nameof(customerDto));
            }

            var customer = CustomerFactory.CreateCustomer(customerDto);

            await this._customerRepository.AddAsync(customer);

            return new CustomerCreatedDto
            {
                Id = customer.Id
            };
        }

        public async Task EditCustomerAsync(EditCustomerDto customerDto)
        {
            throw new NotImplementedException();
        }
    }
}
