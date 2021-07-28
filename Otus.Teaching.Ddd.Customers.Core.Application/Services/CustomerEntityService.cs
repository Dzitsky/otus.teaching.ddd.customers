using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Otus.Teaching.Ddd.Customers.Core.Application.Services.Abstractions;
using Otus.Teaching.Ddd.Customers.Core.Domain.Dto;
using Otus.Teaching.Ddd.Customers.Core.Domain.Entities;
using Otus.Teaching.Ddd.Customers.Domain.Repositories;

namespace Otus.Teaching.Ddd.Customers.Core.Application.Services
{
    public class CustomerEntityService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<JobPlace> _jobPlaceRepository;
        private readonly IRepository<Contact> _contactRepository;

        public CustomerEntityService(IRepository<Customer> customerRepository, IRepository<JobPlace> jobPlaceRepository, IRepository<Contact> contactRepository)
        {
            this._customerRepository = customerRepository;
            this._jobPlaceRepository = jobPlaceRepository;
            this._contactRepository = contactRepository;
        }

        public Task<CustomersForListDto> GetCustomersForListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> GetCustomerAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerCreatedDto> CreateCustomerAsync(CreateCustomerDto customerDto)
        {
            if (customerDto == null)
            {
                throw new ArgumentNullException(nameof(customerDto));
            }

            using var transactionScope = new TransactionScope();

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Channel = customerDto.Channel,
                CreatedDate = DateTime.Now,
                FullName = customerDto.FullName,
                IsActive = true,
            };

            var customerId = await this._customerRepository.AddAsync(customer);

            var jobPlaces = customerDto.JobPlaces?.Select(x => new JobPlace()
            {
                Id = Guid.NewGuid(),
                CustomerId = customerId,
                Description = x.Description,
                StartDate = x.StartDate,
                CompletionDate = x.CompletionDate
            }).ToList();

            if (jobPlaces != null)
            {
                foreach (var jobPlace in jobPlaces)
                {
                    await this._jobPlaceRepository.AddAsync(jobPlace);
                }
            }

            var contacts = customerDto.Contacts?.Select(x => new Contact
            {
                Id = Guid.NewGuid(),
                CustomerId = customerId,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();

            if (contacts != null)
            {
                foreach (var contact in contacts)
                {
                    await this._contactRepository.AddAsync(contact);
                }
            }

            transactionScope.Complete();

            return new CustomerCreatedDto
            {
                Id = customer.Id
            };
        }

        public Task EditCustomerAsync(EditCustomerDto customerDto)
        {
            throw new NotImplementedException();
        }
    }
}
