using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime? CheckOut { get; set; }
        public int TableID { get; set; }
        public int Discount { get; set; } = 0;
        public int TotalPrice { get; set; } = 0;
        public int Status { get; set; } = 0;
    }
}
