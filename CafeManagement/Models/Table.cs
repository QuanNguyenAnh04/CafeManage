using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Models
{
    public class Table
    {
        public int TableID { get; set; }
        public string TableName { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
