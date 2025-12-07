using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public bool Status { get; set; } = true;
        public decimal Price { get; set; } = 0.00m;
        public string ImageURL { get; set; } = string.Empty;

    }
}
