using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Console_Appliction.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }=new List<OrderItem>();
    }
}
