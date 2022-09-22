﻿using System;

 namespace Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer
{
    /// <summary>
    /// Место работы
    /// </summary>
    public class JobPlace
    {
        /// <summary>
        /// Id, уникальный идентификатор
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Описание места работы
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Дата начала работы
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// Дата окончания работы
        /// </summary>
        public DateTime? CompletionDate  { get; }

        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public Guid CustomerId { get; }

        public JobPlace(Customer customer, string description, DateTime startDate, DateTime? completionDate)
        {
            this.Id = Guid.NewGuid();
            this.Description = description;
            this.StartDate = startDate;
            this.CompletionDate = completionDate;
            this.CustomerId = customer.Id;
        }
    }
}
