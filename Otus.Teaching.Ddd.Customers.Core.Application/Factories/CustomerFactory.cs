using System;
using System.Linq;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;
using Otus.Teaching.Ddd.Customers.Core.Domain.Dto;

namespace Otus.Teaching.Ddd.Customers.Core.Application.Factories
{
    public static class CustomerFactory
    {
        public static Customer CreateCustomer(CreateCustomerDto customerDto)
        {
            var customer = new Customer(customerDto.FullName, customerDto.Channel, DateTime.Now);

            var jobPlaces = customerDto.JobPlaces?
                .Select(x => new JobPlace(customer, x.Description, x.StartDate, x.CompletionDate ))
                .ToList();

            customer.AddJobPlaces(jobPlaces);

            var contacts = customerDto.Contacts?
                .Select(x => new Contact(customer, x.Email, x.Phone))
                .ToList();

            customer.AddContacts(contacts);

            return customer;
        }
    }
}
