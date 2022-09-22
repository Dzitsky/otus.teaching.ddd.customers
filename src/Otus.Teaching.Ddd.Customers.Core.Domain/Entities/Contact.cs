﻿using System;

 namespace Otus.Teaching.Ddd.Customers.Core.Domain.Entities
{
    /// <summary>
    /// Контакт клиента
    /// </summary>
    public class Contact
    {
        public Guid Id { get; set; }
        
        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Id клиента
        /// </summary>
        public Guid CustomerId { get; set; }
    }
}