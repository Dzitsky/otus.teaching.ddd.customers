using System;
using System.Collections.Generic;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;

namespace Otus.Teaching.Ddd.Customers.Core.Domain.Entities
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Customer
    {
	    /// <summary>
        /// Id, уникальный идентификатор
        /// </summary>
        public Guid Id { get; set; }
	    
        /// <summary>
        /// Полное имя клиента
        /// </summary>
        public string FullName { get; set; }
	
        /// <summary>
        /// Канал привлечения (интернет-реклама, реклама на улице и т.д.)
        /// </summary>
        public AcquisitionChannel Channel { get; set; }
	
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreatedDate { get; set; }
	
        /// <summary>
        /// Признак активности
        /// </summary>
        public bool IsActive { get; set; }
    }
}

