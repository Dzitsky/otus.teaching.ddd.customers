using System;
using System.Collections.Generic;

namespace Otus.Teaching.Ddd.Customers.Core.Domain.Dto
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        
        public string FullName { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }

        public string Channel { get; set; }

        public string CreatedDate { get; set; }

        public List<JobPlaceDto> JobPlaces { get; set; }
    }
}

