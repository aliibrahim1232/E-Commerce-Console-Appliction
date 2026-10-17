using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Console_Appliction.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
