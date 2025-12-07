using CafeManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.DAO
{
    internal class ProductDAO
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=CafeManagement; Integrated Security=True; TrustServerCertificate=True;";

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = reader["ProductName"] as string ?? string.Empty,
                        CategoryID = (int)reader["CategoryID"],
                        Status = (bool)reader["Status"],
                        // Kiểm tra nếu Price là DBNull, và chuyển từ int sang decimal
                        Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0.00m : Convert.ToDecimal(reader["Price"]),
                        ImageURL = reader["ImageURL"] as string ?? string.Empty
                    });

                }
            }

            return products;
        }
        public List<Product> GetProductsByCategory(int categoryId)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Products WHERE CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = reader["ProductName"] as string ?? string.Empty,
                        CategoryID = (int)reader["CategoryID"],
                        Status = (bool)reader["Status"],
                        // Kiểm tra nếu Price là DBNull, và chuyển đổi đúng kiểu
                        Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0.00m: (reader["Price"] is int ? Convert.ToDecimal(reader["Price"]) : reader.GetDecimal(reader.GetOrdinal("Price"))),
                        ImageURL = reader["ImageURL"] as string ?? string.Empty
                    });

                }
            }

            return products;
        }

        public List<Product> GetProductsByName(string productName)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductName", "%" + productName + "%");  // Tìm kiếm theo tên sản phẩm

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = reader["ProductName"] as string ?? string.Empty,
                        CategoryID = (int)reader["CategoryID"],
                        Status = (bool)reader["Status"],
                        Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0.00m : Convert.ToDecimal(reader["Price"]),
                        ImageURL = reader["ImageURL"] as string ?? string.Empty
                    });
                }
            }

            return products;
        }

        public Product GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Products WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Product
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = reader["ProductName"] as string ?? string.Empty,
                        CategoryID = (int)reader["CategoryID"],
                        Status = (bool)reader["Status"],
                        Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0.00m : Convert.ToDecimal(reader["Price"]),
                        ImageURL = reader["ImageURL"] as string ?? string.Empty
                    };
                }
            }
            return null;
        }

        public void Insert(string name, decimal price, byte[] imageBytes, int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Products (ProductName, Price, ImageURL, CategoryID, Status) VALUES (@name, @price, @image, @categoryId, 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@image", imageBytes == null || imageBytes.Length == 0 ? (object)DBNull.Value : Convert.ToBase64String(imageBytes));
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Products WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Static wrappers to support legacy static calls
        public static Product GetByIdStatic(int id) => new ProductDAO().GetById(id);
        public static void InsertStatic(string name, decimal price, byte[] imageBytes, int categoryId) => new ProductDAO().Insert(name, price, imageBytes, categoryId);
        public static void DeleteStatic(int id) => new ProductDAO().Delete(id);
    }
}