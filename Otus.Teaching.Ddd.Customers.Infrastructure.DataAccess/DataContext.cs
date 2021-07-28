using Microsoft.EntityFrameworkCore;
using Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer;
using Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess.Mapping;

 namespace Otus.Teaching.Ddd.Customers.Core.Infrastructure.DataAccess
{
    public class DataContext
        : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<Contact> Contacts { get; set; }
        
        public DbSet<JobPlace> JobPlaces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerMappingConfiguration());
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
    }
}