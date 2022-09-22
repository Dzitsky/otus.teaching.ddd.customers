using System;
using System.Collections.Generic;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;

namespace Otus.Teaching.Ddd.Customers.Core.Domain.Dto
{
    public class EditCustomerDto
    {
        public Guid Id { get; set; }
        
        public string FullName { get; set; }

        public AcquisitionChannel Channel { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public List<JobPlace> JobPlaces { get; set; }
        
        public List<Contact> Contacts { get; set; }
    }
}
