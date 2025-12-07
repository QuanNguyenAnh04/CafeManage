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

        // Compatibility properties
        public int Id { get => ProductID; set => ProductID = value; }
        public string Name { get => ProductName; set => ProductName = value; }
        public int CategoryId { get => CategoryID; set => CategoryID = value; }

        // Provide a byte[] representation for compatibility with existing code
        public byte[] Image
        {
            get
            {
                if (string.IsNullOrEmpty(ImageURL)) return Array.Empty<byte>();
                try
                {
                    return Convert.FromBase64String(ImageURL);
                }
                catch
                {
                    return Array.Empty<byte>();
                }
            }
            set
            {
                ImageURL = (value == null || value.Length == 0) ? string.Empty : Convert.ToBase64String(value);
            }
        }
    }
}
