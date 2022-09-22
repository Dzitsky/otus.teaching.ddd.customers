﻿using System;

 namespace Otus.Teaching.Ddd.Customers.Core.Domain.Dto
{
    public class JobPlaceDto
    {
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? CompletionDate  { get; set; }
    }
}