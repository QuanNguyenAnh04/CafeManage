using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        // Compatibility properties used by other code
        public int Id { get => CategoryID; set => CategoryID = value; }
        public string Name { get => CategoryName; set => CategoryName = value; }
    }
}
