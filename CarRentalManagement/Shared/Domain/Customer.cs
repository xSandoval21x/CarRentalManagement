using System;
using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : DomainModel 
    {
        public string TaxId { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}