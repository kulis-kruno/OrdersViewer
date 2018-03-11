using System;
using System.Collections.Generic;

namespace OrdersViewer.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
    }
}
