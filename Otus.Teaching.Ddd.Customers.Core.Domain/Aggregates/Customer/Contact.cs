using System;

 namespace Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer
{
    /// <summary>
    /// Контакт клиента
    /// </summary>
    public class Contact
    {
        /// <summary>
        ///Id, Уникальный идентификатор
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public Guid CustomerId { get; }

        public Contact(Customer customer, string email, string phone)
        {
            // todo рассказать про customer параметр и потенциальный рассинхрон

            this.Id = Guid.NewGuid();
            this.Email = email;
            this.Phone = phone;
            this.CustomerId = customer.Id;
        }
    }
}
