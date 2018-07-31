using System;
using System.Collections.Generic;

namespace EFCoreExample.Database
{
    public partial class Address
    {
        public Address()
        {
            CustomerBillingAddress = new HashSet<Customer>();
            CustomerShippingAddress = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string FullAddress { get; set; }

        public ICollection<Customer> CustomerBillingAddress { get; set; }
        public ICollection<Customer> CustomerShippingAddress { get; set; }
    }
}
