using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public partial class Customer
    {
        public int CustomerId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        public ICollection<Order> Orders { get; set; }
        protected Customer() { }
    }
}