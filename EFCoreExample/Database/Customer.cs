using System;
using System.Collections.Generic;

namespace EFCoreExample.Database
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public bool? IsActive { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
