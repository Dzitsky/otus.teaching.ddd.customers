using System;
using System.Collections.Generic;

namespace Otus.Teaching.Ddd.Customers.Core.Domain.Aggregates.Customer
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Customer
    {
	    private readonly List<Contact> _contacts = new List<Contact>();

	    private readonly List<JobPlace> _jobPlaces = new List<JobPlace>();

	    public Guid Id { get; }

	    public string FullName { get; }

	    public AcquisitionChannel Channel { get; }

	    public DateTime CreatedDate { get; }

	    public bool IsActive { get; }

	    public IReadOnlyList<JobPlace> JobPlaces => this._jobPlaces.AsReadOnly();

        public IReadOnlyList<Contact> Contacts => this._contacts.AsReadOnly();

        public Customer(string fullName, AcquisitionChannel acquisitionChannel, DateTime createdDate)
        {
	        this.Id = Guid.NewGuid();
	        this.FullName = fullName;
	        this.Channel = acquisitionChannel;
	        this.CreatedDate = createdDate;
	        this.IsActive = true;
        }

        public void AddJobPlaces(List<JobPlace> jobPlaces)
        {
	        // todo рассказать про null
	        if (jobPlaces != null)
	        {
		        this._jobPlaces.AddRange(jobPlaces);
	        }
        }

        public void AddContacts(List<Contact> contacts)
        {
	        if (contacts != null)
	        {
		        this._contacts.AddRange(contacts);
	        }
        }
    }
}

