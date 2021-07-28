using System.Collections.Generic;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;

namespace Otus.Teaching.Ddd.Customers.Core.Domain.Dto
{
    public class CreateCustomerDto
    {
        public string FullName { get; set; }
        
        public string Title { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public AcquisitionChannel Channel { get; set; }

        public List<JobPlaceDto> JobPlaces { get; set; }
        
        public List<Contact> Contacts { get; set; }
    }
}
