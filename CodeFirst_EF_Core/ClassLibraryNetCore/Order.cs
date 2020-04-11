using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public partial class Order
    {
        public int OrderId { get; set; }

        public float TotalValue { get; set; }

        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        protected Order() { }
    }
}