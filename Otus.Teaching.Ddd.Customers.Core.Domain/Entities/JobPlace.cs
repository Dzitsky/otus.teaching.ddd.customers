﻿using System;

 namespace Otus.Teaching.Ddd.Customers.Core.Domain.Entities
{
    /// <summary>
    /// Место работы
    /// </summary>
    public class JobPlace
    {
        /// <summary>
        /// Id, уникальный идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Описание места работы
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата начала работы
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания работы
        /// </summary>
        public DateTime? CompletionDate  { get; set; }

        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public Guid CustomerId { get; set; }
    }
}